using System;
using System.Windows.Forms;
using UtilitiesForm.Extensions;
using WindowsFormsApplication1.Base;
using posb = PosBusiness;
using System.Linq;

namespace WindowsFormsApplication1
{
    public partial class FaenasList : BaseForm
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

        private int SelectRowIndex
        {
            get
            {
                return gvList.CurrentRow.Index;
            }
        }

        #endregion

        #region Properties

        private posb.Faena Entity { get; set; }

        #endregion #endregion

        #region Builder

        public FaenasList()
        {
            this.Entity = new posb.Faena();

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

                if (this.cmbYear.SelectedIndex > 0)
                    this.Entity.Year = int.Parse(this.cmbYear.Text);
                else
                    this.Entity.Year = null;

                if (this.cmbMonth.SelectedIndex > 0)
                     this.Entity.Month = this.cmbMonth.SelectedIndex;
                else
                     this.Entity.Month = null;

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
            var edit = new Faena(Id);

            edit.Result += new Faena.Communication(Result);

            edit.ShowDialog();
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

        private void FillYears()
        {
            this.cmbYear.Items.Add("Seleccionar...");

            for (int i = 1995; i < 2050; i++)
            {
                this.cmbYear.Items.Add(i);
            }
        }

        private void FillMonth()
        {
            string[] months = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                              "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

            this.cmbMonth.Items.Add("Seleccionar...");

            for (int i = 0; i < months.Length; i++)
            {
                this.cmbMonth.Items.Add(months[i]);
            }
        }

        #endregion

        private void Result(bool IsCorrect, String Message)
        {
            this.FillGridView();
        }

        private void HabitantList_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.txtFind;

            this.FillYears();
            this.FillMonth();

            this.cmbMonth.SelectedIndex = 0;
            this.cmbYear.SelectedIndex = 0;

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
            if (this.Confirm("¿Realmente deseas eliminar la faena " + " [" + this.EntityName + "]?"))
            {
                this.Entity.Id = this.EntityId;

                if (this.Entity.Delete())
                {
                    this.Entity.Id = null;

                    this.FillGridView();
                }
                else
                    this.Alert("Ocurrió un error al intentar eliminar la faena " + " [" + this.EntityName + "]", eForm.TypeError.Error);
            }
        }

        private void gvList_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex.Equals(0) && this.UpdateButton)
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

        private void dtpDate1_ValueChanged(object sender, EventArgs e)
        {
            this.FillGridView();
        }

        private void dtpDate2_ValueChanged(object sender, EventArgs e)
        {
            this.FillGridView();
        }


        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillGridView();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillGridView();
        }

        private void txtFind_KeyUp_1(object sender, KeyEventArgs e)
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
