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
    public partial class HabitantFaena : BaseForm
    {
        #region Memebers

        private int? Id = null;

        public delegate void Communication(bool IsCorrect, String Message);

        public event Communication Result;

        #endregion

        #region Builder

        public HabitantFaena(int? Id)
        {
            this.Id = Id;

            InitializeComponent();
        }

        #endregion

        #region Methods

        private void LoadData(int? Id)
        {
            using (var e = new posb.Faena
            {
                Id = this.Id
            })
            {
                e.Get();
            }
        }

        private void Save()
        {
            using (var e = new posb.Faena
            {
                Id = this.Id,
                IdHabitant = int.Parse(this.cmbHabitant.SelectedValue.ToString()),
                IdFaena = int.Parse(this.cmbFaena.SelectedValue.ToString())
            })
            {
                e.SaveHabitantFaena();

                if (this.Confirm("¿Deseas imprimir el recibo?"))
                {
                    this.PrintFaena(e.Id.Value);
                }

                this.Result(true, "Success!!");

                this.Close();
            }
        }

        private void FillHabitant()
        {
            using (var habitant = new posb.Habitant())
            {
                this.cmbHabitant.Fill(habitant.List());
            }
        }

        private void FillFaena(int? Id = null)
        {
            if (Id.HasValue)
            {
                using (var faena = new posb.Faena
                {
                    Id = Id
                })
                {
                    this.cmbFaena.Fill(faena.ListByHabitant(), Display: "NameCombo");
                }
            }
            else
            {
                this.cmbFaena.Fill(new List<posb.Faena>());
            }
        }

        #endregion

        private void Habitant_Load(object sender, EventArgs e)
        {
            this.FillHabitant();

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

        private void cmbHabitant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbHabitant.SelectedIndex > 0)
            {
                var id = int.Parse(this.cmbHabitant.SelectedValue.ToString());

                this.FillFaena(id);
            }
            else
                this.FillFaena();
        }
    }
}
