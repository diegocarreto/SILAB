using System;
using System.Windows.Forms;
using UtilitiesForm.Extensions;
using WindowsFormsApplication1.Base;
using System.Linq;
using posb = PosBusiness;

namespace WindowsFormsApplication1
{
    public partial class RoleList : BaseForm
    {
        #region Memebers
        #endregion

        #region Properties

        private posb.User Entity { get; set; }

        #endregion #endregion

        #region Builder

        public RoleList()
        {
            this.Entity = new posb.User();

            InitializeComponent();
        }

        #endregion

        #region Methods

        private void FillRole()
        {
            using (posb.User user = new posb.User())
            {
                this.cmbRole.Fill(user.RolList());
            }
        }

        private void OpenEdit()
        {
            int? id = null;
            var name = string.Empty;

            if (this.cmbRole.SelectedIndex > 0)
            {
                id = int.Parse(this.cmbRole.SelectedValue.ToString());
                name = this.cmbRole.Text;
            }

            var role = new RoleEdit(id, name);

            role.Result += new RoleEdit.Communication(Result);

            role.ShowDialog();
        }

        #endregion

        private void Result(bool IsCorrect, String Message)
        {
            this.FillRole();
        }

        private void HabitantList_Load(object sender, EventArgs e)
        {
            this.FillRole();

            this.LoadComplete = true;
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
            this.FillRole();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                if (this.Confirm("¿Realmente deseas eliminar el rol [" + this.cmbRole.Text + "]?"))
                {
                    this.Entity.IdRol = int.Parse(this.cmbRole.SelectedValue.ToString());

                    if (this.Entity.DeleteRole())
                    {
                        this.Entity.IdRol = null;

                        this.FillRole();
                    }
                    else
                        this.Alert("Ocurrió un error al intentar eliminar el rol [" + this.cmbRole.Text + "]", eForm.TypeError.Error);
                }
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.LoadComplete)
            {
                this.tvRole.Nodes.Clear();

                if (!this.cmbRole.SelectedIndex.Equals(0))
                {
                    var idRole = int.Parse(this.cmbRole.SelectedValue.ToString());
                    var index = 0;

                    foreach (var principal in this.Entity.MenuPrincipalList())
                    {
                        this.tvRole.Nodes.Add(principal.Id.ToString(), principal.Name);

                        var index2 = 0;
                        var countChecked = 0;
                        var SecondaryList = this.Entity.MenuSecondaryList(principal.Id.Value, idRole);
                        var buttonList = new System.Collections.Generic.List<posb.User>();

                        foreach (var secondary in SecondaryList)
                        {
                            this.tvRole.Nodes[index].Nodes.Add(secondary.Id.ToString(), secondary.Name);

                            if (secondary.Active.Value)
                            {
                                this.tvRole.Nodes[index].Nodes[index2].Checked = true;
                                countChecked++;
                            }

                            buttonList = this.Entity.MenuSecondaryList(secondary.Id.Value, idRole);
                            var index3 = 0;

                            foreach (var button in buttonList)
                            {
                                this.tvRole.Nodes[index].Nodes[index2].Nodes.Add(button.Id.ToString(), button.Name);

                                if (button.Active.Value)
                                {
                                    this.tvRole.Nodes[index].Nodes[index2].Nodes[index3].Checked = true;
                                    countChecked++;
                                }

                                index3++;
                            }

                            index2++;

                            //if (countChecked.Equals(SecondaryList.Count + buttonList.Count))
                            //    this.tvRole.Nodes[index].Checked = true;
                        }
              
                        index++;
                    }

                    this.tvRole.ExpandAll();
                }

                if (cmbRole.SelectedIndex.Equals(0))
                {
                    this.btnNew.Visible = true;
                    this.btnUpdate.Visible = false;
                }
                else
                {
                    this.btnNew.Visible = false;
                    this.btnUpdate.Visible = true;
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                try
                {
                    var idRole = int.Parse(this.cmbRole.SelectedValue.ToString());

                    this.Entity.UpdateRoleMenuDelete(idRole);

                    foreach (TreeNode node1 in this.tvRole.Nodes)
                    {
                        foreach (TreeNode node2 in node1.Nodes)
                        {
                            if (node2.Checked)
                            {
                                var idMenu = int.Parse(node2.Name);

                                this.Entity.UpdateRoleMenu(idRole, idMenu);
                            }

                            foreach (TreeNode node3 in node2.Nodes)
                            {
                                if (node3.Checked)
                                {
                                    var idButton = int.Parse(node3.Name);

                                    this.Entity.UpdateRoleMenu(idRole, idButton);
                                }
                            }
                        }
                    }

                    this.Alert("Los permisos del rol [" + this.cmbRole.Text + "] se actualizaron correctamente");

                    this.cmbRole.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    this.Alert("Ocurrió un error al intentar cambiar los permisos del rol [" + this.cmbRole.Text + "]", eForm.TypeError.Error);
                }
            }
        }

        private void tvRole_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeNode checkedNode = e.Node;

            foreach (TreeNode node in checkedNode.Nodes)
            {
                node.Checked = checkedNode.Checked;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.OpenEdit();
        }
    }
}
