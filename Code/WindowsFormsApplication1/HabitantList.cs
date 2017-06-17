using System;
using System.Windows.Forms;
using UtilitiesForm.Extensions;
using WindowsFormsApplication1.Base;
using System.Linq;
using posb = PosBusiness;

namespace WindowsFormsApplication1
{
    public partial class HabitantList : BaseForm
    {
        #region Memebers

        private string EntityName
        {
            get
            {
                return gvList[1, this.SelectRowIndex].Value.ToString() + " " + gvList[2, this.SelectRowIndex].Value.ToString();
            }
        }

        private int EntityId
        {
            get
            {
                return int.Parse(gvList[0, this.SelectRowIndex].Value.ToString());
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

        private posb.Habitant Entity { get; set; }

        #endregion #endregion

        #region Builder

        public HabitantList()
        {
            this.Entity = new posb.Habitant();

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
            var WaterIntake = new Habitant(Id);

            WaterIntake.Result += new Habitant.Communication(Result);

            WaterIntake.ShowDialog();
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
            if (this.Confirm("¿Realmente deseas eliminar al habitante [" + this.EntityName + "]?"))
            {
                this.Entity.Id = this.EntityId;

                if (this.Entity.Delete())
                {
                    this.Entity.Id = null;

                    this.FillGridView();
                }
                else
                    this.Alert("Ocurrió un error al intentar eliminar al habitante [" + this.EntityName + "]", eForm.TypeError.Error);
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
            else if (e.ColumnIndex.Equals(10) && this.gvList[10, this.SelectRowIndex].Value.ToString().Equals("Si", StringComparison.InvariantCultureIgnoreCase))
            {
                if (this.Confirm("¿Deseas imprimir el recibo?"))
                {
                    this.PrintHabitant(this.EntityId);
                }
            }
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

        private void txtFind_KeyUp_1(object sender, KeyEventArgs e)
        {
            this.FillGridView();
        }
    }
}
