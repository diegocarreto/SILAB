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
    public partial class Calle : BaseForm
    {
        #region Memebers

        private int? Id = null;

        public delegate void Communication(bool IsCorrect, String Message);

        public event Communication Result;

        #endregion

        #region Builder

        public Calle(int? Id)
        {
            this.Id = Id;

            InitializeComponent();
        }

        #endregion

        #region Methods

        private void LoadData(int? Id)
        {
            using (var e = new posb.Catalogs
            {
                Id = this.Id
            })
            {
                e.Get();

                this.txtName.Text = e.Name;
            }
        }

        private void Save()
        {
            using (var e = new posb.Catalogs
            {
                Id = this.Id,
                Name = this.txtName.Text,
                Type = "Calle"
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
    }
}
