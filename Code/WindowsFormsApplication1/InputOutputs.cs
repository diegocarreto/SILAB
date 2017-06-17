using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Base;
using posb = PosBusiness;

namespace WindowsFormsApplication1
{
    public partial class InputOutputs : BaseForm
    {
        #region Memebers

        private int? Id = null;

        public delegate void Communication(bool IsCorrect, String Message);

        public event Communication Result;

        #endregion

        #region Builder

        public InputOutputs(int? Id)
        {
            this.Id = Id;

            InitializeComponent();
        }

        #endregion

        #region Methods

        private void LoadData(int? Id)
        {
            using (var e = new posb.Expense
            {
                Id = this.Id
            })
            {
                e.Get();

                this.txtName.Text = e.Name;
                this.txtDescription.Text = e.Description;
                this.txtAmount.Text = String.Format("{0:0.00}", e.Amount);
                this.cmbType.SelectedIndex = e.Type.Value + 1;

            }

            using (var e = new posb.Config())
            {
                var picture1 = e.GetImage("InputOutput", this.Id.Value);

                if (picture1 != null)
                {
                    this.pbPhoto.Image = System.Drawing.Image.FromStream(new MemoryStream(picture1));
                    this.pbPhoto.Refresh();
                }
            }
        }

        private void Save()
        {
            using (var e = new posb.Expense
            {
                Id = this.Id,
                Name = this.txtName.Text,
                Description = this.txtDescription.Text,
                Amount = decimal.Parse(this.txtAmount.Text),
                Type = this.cmbType.SelectedIndex - 1
            })
            {
                e.Save();

                this.Result(true, "Success!!");

                this.Close();
            }
        }

        #endregion

        private void Habitant_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.cmbType;
            this.cmbType.SelectedIndex = 0;

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
                this.Save();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var entity = new WaterIntakeList(this.Id);

            entity.ShowDialog();
        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {
            if (this.Id.HasValue)
            {
                var image = new Image(this.Id, "InputOutput");

                image.Result += new Image.Communication(ResultImage1);

                image.ShowDialog();
            }
        }

        private void ResultImage1(bool IsCorrect, String ErrorMessage, System.Drawing.Image Img)
        {
            this.pbPhoto.Image = Img;
        }
    }
}
