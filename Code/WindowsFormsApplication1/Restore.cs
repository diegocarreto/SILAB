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
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Restore : BaseForm
    {
        #region Memebers
        #endregion

        #region Builder

        public Restore()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                if (this.Confirm("¿Realmente deseas restaurar la base de datos SICAP?, Se sugiere realizar un respaldo antes de continuar"))
                {
                    using (posb.Config con = new posb.Config())
                    {
                        var path = Path.GetDirectoryName(this.txtPath.Text);

                        if (Directory.Exists(path))
                        {
                            if (!con.Restore(this.txtPath.Text, true))
                            {
                                this.Alert(con.ErrorMessage);

                                Application.Exit();
                            }
                            else
                            {
                                this.Alert("Se restauro correctamente la base de datos. Debe reiniciar SICAP para aplicar los cambios");
                                Application.Exit();
                            }
                        }
                        else
                        {
                            this.Alert("La carpeta no existe");
                            this.txtPath.Clear();
                            this.txtPath.Focus();
                        }
                    }
                }
            }
        }

        private void Config_Load(object sender, EventArgs e)
        {
            this.ConfigureDialogs();
        }

        private void ConfigureDialogs()
        {
            ofdOpen.FileName = "SICAP.bak";
            ofdOpen.CheckPathExists = true;
            ofdOpen.DefaultExt = "bak";
            ofdOpen.Filter = "Copia de seguridad (*.bak)|*.bak";
            ofdOpen.FilterIndex = 0;
            ofdOpen.Title = "Crear copia de seguridad";
            ofdOpen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofdOpen.RestoreDirectory = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofdOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtPath.Text = ofdOpen.FileName;
            }
        }
    }
}
