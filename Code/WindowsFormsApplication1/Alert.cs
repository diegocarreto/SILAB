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
    public partial class Alert : MetroFramework.Forms.MetroForm
    {
        #region Memebers

        private List<string> Message;

        #endregion

        #region Builder

        public Alert(List<string> Message)
        {
            this.Message = Message;

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
            this.Close();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            this.Message.Reverse();

            //if (this.Message.Count <= 2)
            //{
            //    this.Height = this.Height - 98;
            //    this.txtMessage.Height = this.txtMessage.Height - 98;
            //    this.btnAccept.Top = this.btnAccept.Top - 98;
            //    this.pbSICAP.Top = this.pbSICAP.Top - 98;
            //}
            //else if (this.Message.Count > 2 && this.Message.Count <= 4)
            //{
            //    this.Height = this.Height - 58;
            //    this.txtMessage.Height = this.txtMessage.Height - 58;
            //    this.btnAccept.Top = this.btnAccept.Top - 58;
            //    this.pbSICAP.Top = this.pbSICAP.Top - 58;
            //}

            var myBitmap = new Bitmap(this.pbIcon.Image);
            Clipboard.SetDataObject(myBitmap);
            var myFormat = DataFormats.GetFormat(DataFormats.Bitmap);

            for (int i = 0; i < this.Message.Count; i++)
            {
                var m = this.Message[i];

                this.txtMessage.Paste(myFormat);
                this.txtMessage.AppendText("  " + m + (i != this.Message.Count - 1 ? "\r\n" : string.Empty));
            }

            Clipboard.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
