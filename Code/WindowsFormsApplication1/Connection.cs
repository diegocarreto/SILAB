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
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Connection : BaseForm
    {
        #region Memebers
        #endregion

        #region Builder

        public Connection()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void LoadData()
        {
            using (posb.Config con = new posb.Config())
            {
                string Server = string.Empty;
                int Port = 0;
                string DataBase = string.Empty;
                string User = string.Empty;
                string Password = string.Empty;

                con.GetConnectionParameters(out Server, out Port, out DataBase, out User, out Password);

                this.txtServer.Text = Server;
                this.txtPort.Text = Port.ToString();
                this.txtDataBase.Text = DataBase;
                this.txtUser.Text = User;
                this.txtPassword.Text = Password;
            }
        }

        private void Save()
        {
            using (posb.Config con = new posb.Config())
            {
                con.Save(this.txtServer.Text, int.Parse(this.txtPort.Text), this.txtDataBase.Text, this.txtUser.Text, this.txtPassword.Text);
            }

            this.Alert("La configuración se guardo correctamente. SICAP se reiniciara.");

            Application.Restart();
        }

        private bool TestConnection(out string ErrorMessage, out int ErrorNumber)
        {
            using (var config = new PosBusiness.Config())
            {
                return config.CheckConnection(out ErrorMessage,
                                              out ErrorNumber,
                                              this.txtServer.Text,
                                              this.txtUser.Text,
                                              this.txtPassword.Text,
                                              int.Parse(this.txtPort.Text),
                                              this.txtDataBase.Text);
            }
        }

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                var errorMessage = string.Empty;
                var errorNumber = 0;

                if (!this.TestConnection(out errorMessage, out errorNumber))
                    this.Alert("Ocurrió un error al intentar conectarse a la base de datos SICAP.\r\n\r\nNumero: " + errorNumber + "\r\nDescripción: " + errorMessage);
                else
                    this.Save();
            }
        }

        private void Config_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                var errorMessage = string.Empty;
                var errorNumber = 0;

                if (!this.TestConnection(out errorMessage, out errorNumber))
                    this.Alert("Ocurrió un error al intentar conectarse a la base de datos SICAP.\r\n\r\nNumero: " + errorNumber + "\r\nDescripción: " + errorMessage);
                else
                    this.Alert("Conexión exitosa");
            }
        }
    }
}