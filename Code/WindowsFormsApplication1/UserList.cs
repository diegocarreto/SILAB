using System;
using System.Windows.Forms;
using UtilitiesForm.Extensions;
using WindowsFormsApplication1.Base;
using System.Linq;
using posb = PosBusiness;

namespace WindowsFormsApplication1
{
    public partial class UserList : BaseForm
    {
        #region Memebers

        private string EntityName
        {
            get
            {
                return gvList[1, this.SelectRowIndex].Value.ToString();
            }
        }

        private int EntityId
        {
            get
            {
                return int.Parse(gvList[0, this.SelectRowIndex].Value.ToString());
            }
        }

        private string Active
        {
            get
            {
                return gvList[4, this.SelectRowIndex].Value.ToString();
            }
        }


        private int SelectRowIndex
        {
            get
            {
                return gvList.CurrentRow.Index;
            }
        }

        #endregion

        #region Properties

        private posb.User Entity { get; set; }

        #endregion #endregion

        #region Builder

        public UserList()
        {
            this.Entity = new posb.User();

            InitializeComponent();
        }

        #endregion

        #region Methods

        private void FillGridView()
        {
            this.Entity.Page = this.Page;
            this.Entity.Rows = this.Rows;
            this.Entity.SortName = this.SortName;
            this.Entity.Order = this.Order;

            Entity.Find = this.txtFind.Text;

            this.gvList.AutoGenerateColumns = false;
            this.gvList.AllowUserToResizeColumns = false;

            var list = Entity.List(2);

            this.gvList.DataSource = list;

            if (list.Any())
                this.pageList.SetTotal(list.First().Pages);
        }

        private void OpenEdit(int? Id = null)
        {
            var user = new UserEdit(Id);

            user.Result += new UserEdit.Communication(Result);

            user.ShowDialog();
        }

        #endregion

        private void Result(bool IsCorrect, String Message)
        {
            this.FillGridView();
        }

        private void HabitantList_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.txtFind;

            this.pageList.Result += delegate(int Page, int Rows)
            {
                this.Page = Page;
                this.Rows = Rows;

                this.FillGridView();
            };

            this.FillGridView();

            this.CheckRestoreUser();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.OpenEdit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.FillGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.Confirm("¿Realmente deseas eliminar al usuario [" + this.EntityName + "]?"))
            {
                this.Entity.Id = this.EntityId;

                if (this.Entity.Delete())
                {
                    this.Entity.Id = null;

                    this.FillGridView();
                }
                else
                    this.Alert("Ocurrió un error al intentar eliminar al usuario [" + this.EntityName + "]", eForm.TypeError.Error);
            }
        }

        private void gvList_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.ColumnIndex.Equals(0) && this.UpdateButton) || e.ColumnIndex.Equals(10))
                this.gvList.Cursor = Cursors.Hand;
            else
                this.gvList.Cursor = Cursors.Default;
        }

        private void gvList_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.gvList.Cursor = Cursors.Default;
        }

        private void gvList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex.Equals(0) && this.UpdateButton)
            {
                this.OpenEdit(this.EntityId);
            }
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
           this.FillGridView();
        }

        private void gvList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (gvList.Columns[e.ColumnIndex].SortMode != DataGridViewColumnSortMode.NotSortable)
            {
                this.SortName = gvList.Columns[e.ColumnIndex].Name;

                if (this.Order == ASC)
                    this.Order = DESC;
                else
                    this.Order = ASC;

                this.FillGridView();
            }
        }

        private void txtFind_Click(object sender, EventArgs e)
        {
           
        }

        private void CheckRestoreUser()
        {
            this.btnActivar.Visible = this.Entity.CheckRestoreUser();
        }

        private void btnActivar_Click_1(object sender, EventArgs e)
        {
            if (this.Confirm("¿Realmente deseas activar al usuario [" + this.EntityName + "]?"))
            {
                if (this.Active.Equals("No", StringComparison.InvariantCultureIgnoreCase))
                {
                    this.Entity.Id = this.EntityId;

                    if (this.Entity.RestoreUser())
                    {
                        this.Entity.Id = null;

                        this.FillGridView();
                    }
                    else
                        this.Alert("Ocurrió un error al intentar activar al usuario [" + this.EntityName + "]", eForm.TypeError.Error);
                }
                else 
                {
                    this.Alert("El usuario [" + this.EntityName + "] ya se encuentra activo", eForm.TypeError.Exclamation);
                }
            }
        }
    }
}
