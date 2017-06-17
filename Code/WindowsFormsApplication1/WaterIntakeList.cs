using System;
using System.Windows.Forms;
using UtilitiesForm.Extensions;
using WindowsFormsApplication1.Base;
using posb = PosBusiness;

namespace WindowsFormsApplication1
{
    public partial class WaterIntakeList : BaseForm
    {
        #region Memebers

        private string EntityName
        {
            get
            {
                return this.gvList[1, this.SelectRowIndex].Value.ToString() + " #" +
                       this.gvList[2, this.SelectRowIndex].Value.ToString() +
                       (this.gvList[3, this.SelectRowIndex].Value != null ? " Int" + this.gvList[3, this.SelectRowIndex].Value.ToString() : string.Empty) +
                       (this.gvList[4, this.SelectRowIndex].Value != null ? " " + this.gvList[4, this.SelectRowIndex].Value.ToString() + " " : string.Empty);
            }
        }

        private int EntityId
        {
            get
            {
                return int.Parse(this.gvList[0, this.SelectRowIndex].Value.ToString());
            }
        }

        private int SelectRowIndex
        {
            get
            {
                return this.gvList.CurrentRow.Index;
            }
        }

        #endregion

        #region Properties

        private posb.WaterIntake Entity { get; set; }

        public int? IdHabitant { get; set; }

        public int? Total { get; set; }

        #endregion #endregion

        #region Builder

        public WaterIntakeList(int? IdHabitant)
        {
            this.IdHabitant = IdHabitant;

            this.Entity = new posb.WaterIntake();

            InitializeComponent();
        }

        #endregion

        #region Methods

        private void FillGridView()
        {
            this.Entity.IdHabitant = this.IdHabitant;

            var list = this.Entity.List(2);

            this.gvList.AutoGenerateColumns = false;
            this.gvList.AllowUserToResizeColumns = false;
            this.gvList.DataSource = list;

            this.Total = list.Count;
        }

        private void OpenEdit(int? Id = null)
        {
            var e = new WaterIntake(this.IdHabitant.Value, Id);

            e.Result += new WaterIntake.Communication(Result);

            e.ShowDialog();
        }

        #endregion

        private void Result(bool IsCorrect, String Message)
        {
            this.FillGridView();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (var config = new posb.Config())
            {
                var total = config.WaterIntakeHabitants();

                if (total > this.Total)
                    this.OpenEdit();
                else
                    this.Alert("El numero máximo de tomas de agua por habitante son " + total + ".");
            }
        }

        private void WaterIntakeList_Load(object sender, EventArgs e)
        {
            this.FillGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.Confirm("¿Realmente deseas eliminar la toma de agua:\r\n[" + this.EntityName + "]?"))
            {
                this.Entity.Id = this.EntityId;

                if (this.Entity.Delete())
                {
                    this.Entity.Id = null;

                    this.FillGridView();
                }
                else
                    this.Alert("Ocurrió un error al intentar eliminar la toma de agua [" + this.EntityName + "]", eForm.TypeError.Error);
            }
        }

        private void gvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(0) && this.UpdateButton)
            {
                this.OpenEdit(this.EntityId);
            }
            else if (e.ColumnIndex.Equals(10) && this.gvList[10, this.SelectRowIndex].Value.ToString().Equals("Si", StringComparison.InvariantCultureIgnoreCase))
            {
                if (this.Confirm("¿Deseas imprimir el recibo?"))
                {
                    this.PrintWaterIntake(this.EntityId);
                }
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
    }
}