using System;
using System.Windows.Forms;
using UtilitiesForm.Extensions;
using WindowsFormsApplication1.Base;
using posb = PosBusiness;
using System.Linq;

namespace WindowsFormsApplication1
{
    public partial class InputOutputsList : BaseForm
    {
        #region Memebers

        private string EntityName
        {
            get
            {
                return gvList[2, this.SelectRowIndex].Value.ToString();
            }
        }

        private string EntityType
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

        private int SelectRowIndex
        {
            get
            {
                return gvList.CurrentRow.Index;
            }
        }

        #endregion

        #region Properties

        private posb.Expense Entity { get; set; }

        #endregion #endregion

        #region Builder

        public InputOutputsList()
        {
            this.Entity = new posb.Expense();

            InitializeComponent();
        }

        #endregion

        #region Methods

        private void FillGridView()
        {
            if (this.LoadComplete)
            {
                this.Entity.Page = this.Page;
                this.Entity.Rows = this.Rows;
                this.Entity.SortName = this.SortName;
                this.Entity.Order = this.Order;

                this.Entity.Find = this.txtFind.Text;
                this.Entity.StartDate = this.dtpDate1.Value;
                this.Entity.EndDate = this.dtpDate2.Value;

                if (this.cmbType.SelectedIndex.Equals(0))
                    this.Entity.Type = null;
                else
                    this.Entity.Type = this.cmbType.SelectedIndex - 1;

                var list = this.Entity.List();

                this.gvList.AutoGenerateColumns = false;
                this.gvList.AllowUserToResizeColumns = false;
                this.gvList.DataSource = list;

                if (list.Any())
                    this.pageList.SetTotal(list.First().Pages);
            }
        }

        private void OpenEdit(int? Id = null)
        {
            var WaterIntake = new InputOutputs(Id);

            WaterIntake.Result += new InputOutputs.Communication(Result);

            WaterIntake.ShowDialog();
        }

        private void ConfigureDateTimePicker()
        {
            dtpDate1.Format = DateTimePickerFormat.Custom;
            dtpDate1.CustomFormat = "dd/MM/yyyy";
            dtpDate1.Value = DateTime.Now.AddDays(-30);

            dtpDate2.Format = DateTimePickerFormat.Custom;
            dtpDate2.CustomFormat = "dd/MM/yyyy";
            dtpDate2.Value = DateTime.Now;
        }

        #endregion

        private void Result(bool IsCorrect, String Message)
        {
            this.FillGridView();
        }

        private void HabitantList_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.txtFind;

            this.cmbType.SelectedIndex = 0;

            this.ConfigureDateTimePicker();

            this.LoadComplete = true;

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
            if (this.Confirm("¿Realmente deseas eliminar el " + this.EntityType.ToLower() + " [" + this.EntityName + "]?"))
            {
                this.Entity.Id = this.EntityId;

                if (this.Entity.Delete())
                {
                    this.Entity.Id = null;

                    this.FillGridView();
                }
                else
                    this.Alert("Ocurrió un error al intentar eliminar el " + this.EntityType.ToLower() + " [" + this.EntityName + "]", eForm.TypeError.Error);
            }
        }

        private void gvList_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex.Equals(0) && this.UpdateButton)
                this.gvList.Cursor = Cursors.Hand;
            else if (e.ColumnIndex.Equals(6))
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
            else if (e.ColumnIndex.Equals(6) && gvList[6, this.SelectRowIndex].Value.ToString().Equals("Si", StringComparison.InvariantCultureIgnoreCase))
            {
                var vi = new ViewImage(this.EntityId, "InputOutput", this.EntityName + "_" + this.EntityId);

                vi.ShowDialog();
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillGridView();
        }

        private void dtpDate1_ValueChanged(object sender, EventArgs e)
        {
            this.FillGridView();
        }

        private void dtpDate2_ValueChanged(object sender, EventArgs e)
        {
            this.FillGridView();
        }

        private void txtFind_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

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
    }
}
