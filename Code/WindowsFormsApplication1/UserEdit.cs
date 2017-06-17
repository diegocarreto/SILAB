using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Base;
using UtilitiesForm.Extensions;
using posb = PosBusiness;

namespace WindowsFormsApplication1
{
    public partial class UserEdit : BaseForm
    {
        #region Memebers

        private int? Id = null;

        public delegate void Communication(bool IsCorrect, String Message);

        public event Communication Result;

        #endregion

        #region Builder

        public UserEdit(int? Id)
        {
            this.Id = Id;

            InitializeComponent();
        }

        #endregion

        #region Methods

        private void LoadData(int? Id)
        {
            using (var e = new posb.User
            {
                Id = this.Id
            })
            {
                e.Get();

                this.txtName.Text = e.Name;
                this.txtAlias.Text = e.Alias;
                this.txtNewPassword.Text = e.Password;
                this.txtNewRepeatPassword.Text = e.Password;
                this.cbActive.Checked = e.Active.Value;
                this.cmbRol.SelectedValue = e.IdRol;

                this.cbUsePassword.Checked = e.UsePassword.Value;
                this.cbBiometric.Checked = e.UseBiometric.Value;

                this.txtNewPassword.Enabled = false;
                this.txtNewRepeatPassword.Enabled = false;
            }
        }

        private void Save()
        {
            using (var e = new posb.User
            {
                    Id = this.Id,
                    Name = this.txtName.Text,
                    Alias = this.txtAlias.Text,
                    IdRol = int.Parse(this.cmbRol.SelectedValue.ToString()),
                    Password = this.txtNewPassword.Text,
                    Active = this.cbActive.Checked,
                    UseBiometric = this.cbBiometric.Checked,
                    UsePassword = this.cbUsePassword.Checked
            })
            {
                e.Save();

                this.Result(true, "Success!!");

                this.Close();
            }
        }

        private void FillRol()
        {
            using (var user = new posb.User())
            {
                this.cmbRol.Fill(user.RolList());
            }
        }


        #endregion

        private void Habitant_Load(object sender, EventArgs e)
        {
            this.FillRol();

            if (this.Id.HasValue)
            {
                this.LoadData(this.Id);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                if (this.txtNewPassword.Text.Equals(this.txtNewRepeatPassword.Text))
                {
                    if (this.txtNewPassword.Text.Length > 5)
                    {
                        this.Save();
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
        }

        private void btnBiometric_Click(object sender, EventArgs e)
        {
            var biometric = new UserFingerEdit(this.Id);

            biometric.ShowDialog();
        }
    }
}
