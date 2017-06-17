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
    public partial class Image : BaseForm
    {
        #region Memebers

        public delegate void Communication(bool IsCorrect, String ErrorMessage, System.Drawing.Image Img);

        public event Communication Result;

        private int? Id = null;

        private string EntityName = string.Empty;

        #endregion

        #region Builder

        public Image(int? Id = null, string EntityName ="")
        {
            InitializeComponent();

            this.Id = Id;
            this.EntityName = EntityName;
        }

        #endregion

        #region Methods

        private byte[] ImageToByte(System.Drawing.Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private void Save()
        {
            if (pbPhoto.Image != null)
            {
                using (posb.Config con = new posb.Config())
                {
                    con.SaveImage(this.EntityName, this.Id.Value, this.ImageToByte(pbPhoto.Image));
                }

                this.Result(true, "", pbPhoto.Image);

                this.Close();
            }
            else
            {
                this.Alert("Seleccione una imagen");
            }
        }

        private void ConfigureOpenFileDialog()
        {
            ofdDocument.FileName = string.Empty;

            ofdDocument.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofdDocument.Title = "Seleccione la imagen";

            ofdDocument.DefaultExt = "jpg";
            ofdDocument.Filter = "Imagenes jpg (*.jpg)|*.jpg|Imagenes png (*.png)|*.png";
        }

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            this.ConfigureOpenFileDialog();
        }

        private void btnURL_Click(object sender, EventArgs e)
        {
            if (ofdDocument.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = ofdDocument.FileName;

                pbPhoto.Image = new Bitmap(ofdDocument.FileName);
            }
        }
    }
}
