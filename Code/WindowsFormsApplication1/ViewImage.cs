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
using System.Drawing.Imaging;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class ViewImage : BaseForm
    {
        #region Memebers

        private int? Id = null;

        private string EntityName = string.Empty;

        private string ImagenName = string.Empty;

        #endregion

        #region Builder

        public ViewImage(int? Id = null, string EntityName = "", string ImagenName = "")
        {
            InitializeComponent();

            this.Id = Id;
            this.EntityName = EntityName;
            this.ImagenName = ImagenName;
        }

        #endregion

        #region Methods

        private void ConfigureDialogs()
        {
            this.svdSave.Title = "Guardar como";
            this.svdSave.DefaultExt = "jpg";
            this.svdSave.Filter = "Imagen JPG (*.JPG)|*.JPG";
            this.svdSave.FilterIndex = 0;
            this.svdSave.CheckPathExists = true;
            this.svdSave.RestoreDirectory = true;
            this.svdSave.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            this.svdSave.FileName = ImagenName + ".jpg";
        }

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            this.ConfigureDialogs();

            using (var c = new posb.Config())
            {
                var picture1 = c.GetImage(this.EntityName, this.Id.Value);

                if (picture1 != null)
                {
                    this.pbPhoto.Image = System.Drawing.Image.FromStream(new MemoryStream(picture1));
                    this.pbPhoto.Refresh();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.svdSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pbPhoto.Image.Save(this.svdSave.FileName, ImageFormat.Jpeg);

                if (this.Confirm("¿Deseas abrir la imagen?"))
                    Process.Start(this.svdSave.FileName);
            }
        }
    }
}