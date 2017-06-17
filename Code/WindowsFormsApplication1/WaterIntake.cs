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
    public partial class WaterIntake : BaseForm
    {
        #region Memebers

        private const string STREET = "Calle";

        private int? Id = null;

        private int? IdHabitant = null;

        public delegate void Communication(bool IsCorrect, String Message);

        public event Communication Result;

        #endregion

        #region Builder

        public WaterIntake(int IdHabitant, int? Id = null)
        {
            this.IdHabitant = IdHabitant;
            this.Id = Id;

            InitializeComponent();
        }

        #endregion

        #region Methods

        private void FillHabitant()
        {
            using (var habitant = new posb.Habitant())
            {
                this.cmbHabitant.Fill(habitant.List());
            }
        }

        private void FillStreet()
        {
            using (var e = new PosBusiness.Catalogs())
            {
                this.cmbStreet.Fill(e.List(STREET));
            }
        }

        private void Save()
        {
            using (var e = new posb.WaterIntake
            {
                Id = this.Id,
                IdHabitant = this.IdHabitant,
                IdStreet = this.cmbStreet.GetVal<int>(),
                IdRent = this.cmbHabitant.GetVal<int>(),
                ExteriorNumber = this.txtExteriorNumber.Text,
                InteriorNumber = this.txtInteriorNumber.Text,
                Colony = this.txtColony.Text,
                Active = this.cbActive.Checked,
                Total = decimal.Parse(this.txtTotal.Text),
                Principal = this.cbPrincipal.Checked,
                Type = this.cmbType.Text
            })
            {
                e.Save();

                if (e.Total > 0)
                {
                    if (this.Confirm("¿Deseas imprimir el recibo?"))
                    {
                        this.PrintWaterIntake(e.Id.Value);
                    }
                }

                this.Result(true, "Success!!");

                this.Close();
            }
        }

        private void LoadData(int? Id)
        {
            using (var e = new posb.WaterIntake
            {
                Id = this.Id
            })
            {
                e.Get();

                if (e.IdRent.HasValue)
                    this.cmbHabitant.SelectedValue = e.IdRent;
                
                this.cmbStreet.SelectedValue = e.IdStreet;
                this.txtExteriorNumber.Text = e.ExteriorNumber;
                this.txtInteriorNumber.Text = e.InteriorNumber;
                this.txtColony.Text = e.Colony;
                this.txtTotal.Text = String.Format("{0:0.00}", e.Total);
                this.cbActive.Checked = e.Active.Value;
                this.cbPrincipal.Checked = e.Principal.Value;
                this.cmbType.Text = e.Type;
            }
        }

        private void SetCostAlta()
        {
            try
            {
                using (var e = new posb.Config())
                {
                    if(this.cmbType.SelectedIndex.Equals(0))
                        this.txtTotal.Text = String.Format("{0:0.00}", e.Alta());
                    else
                        this.txtTotal.Text = String.Format("{0:0.00}", e.AltaNegocio());
                }
            }
            catch (Exception ex)
            { 
            
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

        private void WaterIntake_Load(object sender, EventArgs e)
        {
            this.cmbType.SelectedIndex = 0;

            this.FillStreet();
            this.FillHabitant();

            if (this.Id.HasValue)
            {
                this.LoadData(this.Id);
            }
            else
            {
                this.SetCostAlta();
            }

            this.LoadComplete = true;
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.LoadComplete)
                this.SetCostAlta();
        }
    }
}
