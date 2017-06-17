using System;
using System.Windows.Forms;
using Utilities;
using Utilities.Extensions;
using posb = PosBusiness;
using UtilitiesForm.Extensions;
using System.Resources;
using System.Collections.Generic;
using System.Reflection;

namespace WindowsFormsApplication1
{
    public partial class Sicap : Form
    {
        #region Members

        public BackUp BackUp;

        public string UserName;

        public Login Login;

        private Dictionary<string, Form> Forms;

        #endregion

        #region Builder

        public Sicap()
        {
            this.Forms = new Dictionary<string, Form>();

            InitializeComponent();
        }

        #endregion

        #region Events

        private void MaxShop_Load(object sender, EventArgs e)
        {
            this.AddMenu();
            this.AddStatusBar();
        }

        private void bloquearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            this.Login.Show();
        }

        private void Sicap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Login != null)
                this.Login.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var About = new About();

            About.ShowDialog();
        }

        private void mnArchivoReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void mnArchivoSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Methods

        private void AddMenu()
        {
            try
            {
                using (var e = new PosBusiness.User())
                {
                    e.Rol();

                    var principal = e.MenuPrincipalList();

                    foreach (var p in principal)
                    {
                        var mnu = (ToolStripMenuItem)menuStrip1.Items.Add(p.Name);
                        var secondary = e.MenuSecondaryByUserList(p.Id.Value);
                        var index = 0;

                        foreach (var s in secondary)
                        {
                            System.Drawing.Image img = System.Drawing.Image.FromFile(this.GetPath() + "\\Menu\\" + s.Image, true);

                            mnu.DropDownItems.Add(s.Name, img, MenuClicked);
                            mnu.DropDownItems[index].Tag = s.FormName + "|" + s.Modal;

                            index++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.Alert("Ocurrió un error al intentar generar el menú de navegación. Descripción: \r\n" + ex.Message);
            }
        }

        private void MenuClicked(object sender, EventArgs e)
        {
            var nameSpace = "WindowsFormsApplication1.";
            var menu = (ToolStripMenuItem)sender;
            var parts = menu.Tag.ToString().Split('|');

            var frmName = parts[0];
            var frm = new Form();

            bool modal = false;
            bool.TryParse(parts[1], out modal);

            if (!this.Forms.ContainsKey(frmName))
            {
                frm = Activator.CreateInstance(Type.GetType(nameSpace + frmName)) as Form;
                this.Forms.Add(frmName, frm);
            }
            else if (modal)
            {
                frm = Activator.CreateInstance(Type.GetType(nameSpace + frmName)) as Form;
            }
            else
            {
                frm = this.Forms[frmName];

                if (frm.IsDisposed)
                    frm = Activator.CreateInstance(Type.GetType(nameSpace + frmName)) as Form;
            }


            if (modal)
                frm.ShowDialog();
            else
            {
                frm.StartPosition = FormStartPosition.CenterScreen;

                frm.MdiParent = this;

                frm.Show();
                frm.Activate();
            }
        }

        private void AddStatusBar()
        {
            StatusBar main = new StatusBar();

            StatusBarPanel statusPanel = new StatusBarPanel();
            StatusBarPanel statusVersion = new StatusBarPanel();
            StatusBarPanel dateTimePanel = new StatusBarPanel();
            StatusBarPanel serverPanel = new StatusBarPanel();


            statusPanel.BorderStyle = StatusBarPanelBorderStyle.Sunken;
            statusPanel.Text = "Usuario.- " + UserName;
            statusPanel.ToolTipText = UserName;
            statusPanel.AutoSize = StatusBarPanelAutoSize.Spring;

            main.Panels.Add(statusPanel);

            statusVersion.BorderStyle = StatusBarPanelBorderStyle.Sunken;
            statusVersion.Text = "SILAB V1.0.0";
            statusVersion.AutoSize = StatusBarPanelAutoSize.Spring;

            main.Panels.Add(statusVersion);


            dateTimePanel.BorderStyle = StatusBarPanelBorderStyle.Raised;
            dateTimePanel.Text = DateTime.Today.ToLongDateString();
            dateTimePanel.ToolTipText = "Fecha: " + DateTime.Today.ToString("dd/MM/yyyy");
            dateTimePanel.AutoSize = StatusBarPanelAutoSize.Spring;

            main.Panels.Add(dateTimePanel);

            main.ShowPanels = true;

            this.Controls.Add(main);
        }

        #endregion
    }
}