using System;
using WindowsFormsApplication1.Base;
using posb = PosBusiness;
using UtilitiesForm.Extensions;

namespace WindowsFormsApplication1
{
    public partial class BranchOfficeEdit : BaseForm
    {
        #region Memebers

        public delegate void Communication(bool IsCorrect, String Message);

        public event Communication Result;

        #endregion

        #region Properties

        public posb.BranchOffice Eny { get; set; }

        #endregion

        #region Builder

        public BranchOfficeEdit(int? Id)
        {
            this.Eny = new posb.BranchOffice
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
    }
}