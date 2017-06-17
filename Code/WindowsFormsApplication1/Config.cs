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

namespace WindowsFormsApplication1
{
    public partial class Config : BaseForm
    {
        #region Memebers
        #endregion

        #region Builder

        public Config()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void LoadData()
        {
            this.cmbPrinter.Items.Add("Seleccione...");

            foreach (var printer in PrinterSettings.InstalledPrinters)
            {
                this.cmbPrinter.Items.Add(printer);
            }

            this.cmbPrinter.SelectedIndex = 0;

            using (var e = new posb.Config())
            {
                this.txtAlta.Text = String.Format("{0:0.00}", e.Alta());
                this.txtAltaNegocio.Text = String.Format("{0:0.00}", e.AltaNegocio());
                this.txtMensualidad.Text = String.Format("{0:0.00}", e.Mensualidad());
                this.txtMensualidadNegocio.Text = String.Format("{0:0.00}", e.MensualidadNegocio());
                this.cmbPrinter.Text = e.Printer();
                this.txtPresidente.Text = e.Presidente();
                this.txtTesorero.Text = e.Tesorero();
                this.txtAltaH.Text = String.Format("{0:0.00}", e.AltaH());
                this.cbAddNames.Checked = e.AltaAddNames();
                this.nudTomas.Value = e.WaterIntakeHabitants();

                var picture1 = e.GetImage("Voucher", 1);

                if (picture1 != null)
                {
                    this.pbPhoto.Image = System.Drawing.Image.FromStream(new MemoryStream(picture1));
                    this.pbPhoto.Refresh();
                }

                var picture2 = e.GetImage("Voucher", 2);

                if (picture1 != null)
                {
                    this.pbPhoto2.Image = System.Drawing.Image.FromStream(new MemoryStream(picture2));
                    this.pbPhoto2.Refresh();
                }
            }
        }

        private void Save()
        {
            if (this.ValidateForm())
            {
                using (var e = new posb.Config())
                {
                    e.Alta(this.txtAlta.Text);
                    e.AltaNegocio(this.txtAltaNegocio.Text);
                    e.Mensualidad(this.txtMensualidad.Text);
                    e.MensualidadNegocio(this.txtMensualidadNegocio.Text);
                    e.Printer(this.cmbPrinter.Text);
                    e.Presidente(this.txtPresidente.Text);
                    e.Tesorero(this.txtTesorero.Text);
                    e.AltaH(this.txtAltaH.Text);
                    e.AltaAddNames(this.cbAddNames.Checked);
                    e.WaterIntakeHabitants(this.nudTomas.Value.ToString());
                }

                this.Close();
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
            this.LoadData();
        }

        private void cbActive_CheckedChanged(object sender, EventArgs e)
        {
            this.txtTesorero.Enabled = this.cbAddNames.Checked;
            this.txtPresidente.Enabled = this.cbAddNames.Checked;
        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {
            var image = new Image(1, "Voucher");

            image.Result += new Image.Communication(ResultImage1);

            image.ShowDialog();
        }

        private void ResultImage1(bool IsCorrect, String ErrorMessage, System.Drawing.Image Img)
        {
            this.pbPhoto.Image = Img;
        }

        private void pbPhoto2_Click(object sender, EventArgs e)
        {
            var image = new Image(2);

            image.Result += new Image.Communication(ResultImage2);

            image.ShowDialog();
        }

        private void ResultImage2(bool IsCorrect, String ErrorMessage, System.Drawing.Image Img)
        {
            this.pbPhoto2.Image = Img;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
