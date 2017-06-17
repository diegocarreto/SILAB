using System;
using WindowsFormsApplication1.Base;
using posb = PosBusiness;

namespace WindowsFormsApplication1
{
    public partial class RoleEdit : BaseForm
    {
        #region Memebers

        private int? Id = null;

        private string RoleName = string.Empty;

        public delegate void Communication(bool IsCorrect, String Message);

        public event Communication Result;

        #endregion

        #region Builder

        public RoleEdit(int? Id, string RoleName)
        {
            this.Id = Id;
            this.RoleName = RoleName;

            InitializeComponent();
        }

        #endregion

        #region Methods
        
        private void LoadData()
        {
            this.txtName.Text = this.RoleName;
        }

        private void Save()
        {
            using (var e = new posb.User
            {
                Id = this.Id,
                Name = this.txtName.Text
            })
            {
                e.SaveRole();

                this.Result(true, "Success!!");

                this.Close();
            }
        }

        #endregion

        private void Habitant_Load(object sender, EventArgs e)
        {
            if (this.Id.HasValue)
            {
                this.LoadData();
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
    }
}
