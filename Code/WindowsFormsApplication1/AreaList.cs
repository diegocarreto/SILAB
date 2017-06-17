using System;
using System.Linq;
using System.Windows.Forms;
using UtilitiesForm.Extensions;
using WindowsFormsApplication1.Base;
using posb = PosBusiness;

namespace WindowsFormsApplication1
{
    public partial class AreaList : BaseForm
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

        private posb.Area Entity { get; set; }

        #endregion #endregion

        #region Builder

        public AreaList()
        {
            this.Entity = new posb.Area();

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
            var edit = new BranchOfficeEdit(Id);

            edit.Result += new BranchOfficeEdit.Communication(Result);

            edit.ShowDialog();
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
            if (this.Confirm("¿Realmente deseas eliminar el area [" + this.EntityName + "]?"))
            {
                this.Entity.Id = this.EntityId;

                if (this.Entity.Delete())
                {
                    this.Entity.Id = null;

                    this.FillGridView();
                }
                else
                    this.Alert("Ocurrió un error al intentar eliminar el area [" + this.EntityName + "]", eForm.TypeError.Error);
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
                this.SortName = gvList.Columns[e.ColumnIndex].DataPropertyName;

                if (this.Order == ASC)
                    this.Order = DESC;
                else
                    this.Order = ASC;

                this.FillGridView();
            }
        }
    }
}