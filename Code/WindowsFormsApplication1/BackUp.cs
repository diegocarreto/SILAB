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
    public partial class BackUp : BaseForm
    {
        #region Memebers
        #endregion

        #region Builder

        public BackUp()
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
                using (posb.Config con = new posb.Config())
                {
                    var path = Path.GetDirectoryName(this.txtPath.Text);

                    if (Directory.Exists(path))
                    {
                        if (!con.BackUp(this.txtPath.Text))
                        {
                            this.Alert(con.ErrorMessage);
                        }
                        else
                        {
                            if (this.Confirm("El respaldo se creo correctamente, ¿Deseas abrir la carpeta?"))
                                Process.Start(path);

                            this.Close();
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

        private void Config_Load(object sender, EventArgs e)
        {
            this.ConfigureDialogs();
        }

        private void ConfigureDialogs()
        {
            svdReportStock.CheckPathExists = true;
            svdReportStock.DefaultExt = "bak";
            svdReportStock.Filter = "Copia de seguridad (*.bak)|*.bak";
            svdReportStock.FilterIndex = 0;
            svdReportStock.Title = "Crear copia de seguridad";
            svdReportStock.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            svdReportStock.RestoreDirectory = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            svdReportStock.FileName = "SICAP_" + DateTime.Now.ToString("ddMMyyyy_hhmmss") + ".bak";

            if (svdReportStock.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtPath.Text = svdReportStock.FileName;
            }
        }
    }
}
