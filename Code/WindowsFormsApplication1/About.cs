using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Base;
using posb = PosBusiness;
using UtilitiesForm.Extensions;

namespace WindowsFormsApplication1
{
    public partial class About : BaseForm
    {
        #region Memebers
        #endregion

        #region Builder

        public About()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            this.txtTXT.Text =
@"Advertencia: Este programa está protegido por las
leyes de derechos de autor y otros tratados 
internacionales. La reproducción y distribución no 
autorizada de este programa o de cualquier parte del 
mismo está penada por la ley con severas sanciones 
civiles y penales  y será objeto de toda las acciones
judiciales que correspondan.";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("mailto:" + linkLabel1.Text);
        }
    }
}
