using System;
using WindowsFormsApplication1.Base;
using posb = PosBusiness;
using UtilitiesForm.Extensions;

namespace WindowsFormsApplication1
{
    public partial class ProviderEdit : BaseForm
    {
        #region Memebers

        public delegate void Communication(bool IsCorrect, String Message);

        public event Communication Result;

        #endregion

        #region Properties

        public posb.Provider Eny { get; set; }

        #endregion

        #region Builder

        public ProviderEdit(int? Id)
        {
            this.Eny = new posb.Provider
            {
                Id = Id
            };

            InitializeComponent();
        }

        #endregion

        #region Methods

        private void LoadData()
        {
            if (this.Eny.Id.HasValue)
            {
                this.Eny.List(IsDto: true);

                this.SetControlValue(this.Eny);

                this.txtName.Focus();
            }
        }

        private void Save()
        {
            this.LoadEntity(this.Eny);

            this.Eny.Save();

            this.Result(true, "Success!!");

            this.Close();
        }

        #endregion

        private void Habitant_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtName;

            this.LoadData();
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroTextBox9_Click(object sender, EventArgs e)
        {

        }

        private void pbval_txtStreet_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone1_Click(object sender, EventArgs e)
        {

        }

        private void txtContact1_Click(object sender, EventArgs e)
        {

        }

        private void txtPosition1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail1_Click(object sender, EventArgs e)
        {

        }

        private void txtContact2_Click(object sender, EventArgs e)
        {

        }

        private void txtPosition2_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail2_Click(object sender, EventArgs e)
        {

        }

        private void txtColony_Click(object sender, EventArgs e)
        {

        }

        private void txtStreet_Click(object sender, EventArgs e)
        {

        }

        private void txtMunicipality_Click(object sender, EventArgs e)
        {

        }

        private void txtCP_Click(object sender, EventArgs e)
        {

        }

        private void txtTerms_Click(object sender, EventArgs e)
        {

        }

        private void txtCondition_Click(object sender, EventArgs e)
        {

        }

        private void txtRubric_Click(object sender, EventArgs e)
        {

        }

        private void cbActive_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}