using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Base;
using posb = PosBusiness;
using UtilitiesForm.Extensions;

namespace WindowsFormsApplication1
{
    public partial class User : BaseForm
    {
        #region Memebers
        #endregion

        #region Builder

        public User()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void Save()
        {
            if (this.txtNewPassword.Text.Equals(this.txtNewRepeatPassword.Text))
            {
                if (this.txtNewPassword.Text.Length > 5)
                {
                    using (var user = new PosBusiness.User
                    {
                        Password = this.txtCurrentPassword.Text
                    })
                    {
                        user.Alias = user.UserAlias;

                        if (user.Login())
                        {
                            if (user.ChangePassword(user.UserId.Value, this.txtNewPassword.Text))
                            {
                                this.Alert("La contraseña se cambio correctamente", eForm.TypeError.Exclamation);

                                this.Close();
                            }
                            else
                                this.Alert("Ocurrió un error al intentar cambiar la contraseña", eForm.TypeError.Error);
                        }
                        else
                        {
                            this.Alert("La contraseña proporcionada es incorrecta", eForm.TypeError.Exclamation);

                            this.txtCurrentPassword.Clear();
                        }
                    }
                }
                else
                {
                    this.Alert("La contraseña debe tener al menos 6 caracteres");

                    this.txtNewRepeatPassword.Clear();

                    this.txtNewPassword.Clear();
                    this.txtNewPassword.Focus();
                }
            }
            else
            {
                this.Alert("Las contraseñas capturadas no coinciden");

                this.txtNewRepeatPassword.Clear();
                this.txtNewPassword.Focus();
            }
        }

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                this.Save();
            }
        }

        private void Config_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.txtNewPassword;
        }
    }
}