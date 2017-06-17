using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Pager : UserControl
    {
        #region Members

        public delegate void Communication(int Page, int Rows);

        public event Communication Result;

        #endregion

        #region Builder

        public Pager()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private int? GetPage(MovementTypePage MovementType = MovementTypePage.None)
        {
            int page = 0;

            if (int.TryParse(this.txtPageCurrent.Text, out page))
            {
                if (MovementType == MovementTypePage.Next)
                    page++;
                else if (MovementType == MovementTypePage.Previous)
                    page--;

                return page;
            }
            else
                return null;
        }

        private void MovePage(int? Page = null, bool First = false, bool Last = false)
        {
            var total = int.Parse(this.txtPageTotal.Text);

            if (First)
                Page = 1;

            if (Last)
                Page = total;

            if (Page.HasValue)
            {
                var rows = int.Parse(this.cmbRows.Text);

                if (Page <= 0)
                    Page = total;
                else if (Page > total)
                    Page = 1;

                this.txtPageCurrent.Text = Page.ToString();

                if (this.Result != null)
                    this.Result(Page.Value, rows);
            }
        }

        public void SetTotal(int total)
        {
            this.txtPageTotal.Text = total.ToString();
        }

        #endregion

        #region Events

        private void Pager_Load(object sender, EventArgs e)
        {
            this.cmbRows.SelectedIndex = 0;
        }
        
        private void btnPageLast_Click(object sender, EventArgs e)
        {
            this.MovePage(Last: true);
        }

        private void btnPageNext_Click(object sender, EventArgs e)
        {
            var page = this.GetPage(MovementTypePage.Next);

            this.MovePage(page);
        }

        private void btnPagePrevious_Click(object sender, EventArgs e)
        {
            var page = this.GetPage(MovementTypePage.Previous);

            this.MovePage(page);
        }

        private void btnPageFirst_Click(object sender, EventArgs e)
        {
            this.MovePage(First: true);
        }

        private void cmbRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.MovePage(First: true);
        }

        private void txtPageCurrent_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        private void txtPageCurrent_KeyUp_1(object sender, KeyEventArgs e)
        {
            var page = this.GetPage();

            this.MovePage(page);
        }

        #endregion
    }

    public enum MovementTypePage
    {
        Next,
        Previous,
        None
    }
}
