using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ConfigureDateTimePicker();

            this.cmbProduct.SelectedIndex = 0;
            this.cmbDataBase.SelectedIndex = 0;

            this.ActiveControl = this.txtServer;
        }

        private void ConfigureDateTimePicker()
        {
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd/MM/yyyy";
            dtpDate.Value = DateTime.Now.AddDays(365);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtServer.Text))
                {
                    MessageBox.Show("Indique el servidor", "Padlock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtServer.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.txtUser.Text))
                {
                    MessageBox.Show("Indique el usuario", "Padlock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtUser.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.txtPassword.Text))
                {
                    MessageBox.Show("Indique la contraseña", "Padlock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPassword.Focus();
                    return;
                }

                if (this.cmbDataBase.SelectedIndex.Equals(0))
                {
                    MessageBox.Show("Seleccione la base de datos", "Padlock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cmbDataBase.Focus();
                    return;
                }

                if (this.cmbProduct .SelectedIndex.Equals(0))
                {
                    MessageBox.Show("Seleccione el producto", "Padlock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cmbProduct.Focus();
                    return;
                }

                const int keySize = 1024;
                string publicAndPrivateKey;
                string publicKey;

                AsymmetricEncryption.GenerateKeys(keySize, out publicKey, out publicAndPrivateKey);

                var text = this.cmbProduct.Text + "|" + dtpDate.Value.ToString("dd/MM/yyyy");
                var encrypted = AsymmetricEncryption.EncryptText(text, keySize, publicKey);

                var query = @"UPDATE config SET value = '" + encrypted + "' WHERE [key] = 'key'";
                var connection = "Data Source=" + this.txtServer.Text +
                                 ";Initial Catalog=" + this.cmbDataBase.Text +
                                 ";User Id=" + this.txtUser.Text +
                                 ";Password=" + this.txtPassword.Text;

                using (var con = new SqlConnection(connection))
                {
                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();

                        cmd.ExecuteNonQuery();
                    }
                }

                var query2 = @"UPDATE config SET value = '" + publicAndPrivateKey + "' WHERE [key] = 'publicKey'";

                using (var con = new SqlConnection(connection))
                {
                    using (var cmd = new SqlCommand(query2, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Se activo correctamente el producto: " + this.cmbProduct.Text, "Padlock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cmbDataBase.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al activar el producto: " + this.cmbProduct.Text + "\r\nDescripción: " + ex.Message, "Padlock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtServer.Text))
                {
                    MessageBox.Show("Indique el servidor", "Padlock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtServer.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.txtUser.Text))
                {
                    MessageBox.Show("Indique el usuario", "Padlock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtUser.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.txtPassword.Text))
                {
                    MessageBox.Show("Indique la contraseña", "Padlock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPassword.Focus();
                    return;
                }

                var query = @"select name from sys.sysdatabases";
                var connection = "Data Source=" + this.txtServer.Text +
                                 ";User Id=" + this.txtUser.Text +
                                 ";Password=" + this.txtPassword.Text;

                using (var con = new SqlConnection(connection))
                {
                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();

                        using (var ada = new SqlDataAdapter(cmd))
                        {
                            using (var dt = new DataTable())
                            {
                                ada.Fill(dt);

                                this.cmbDataBase.Items.Add("Seleccione...");

                                foreach(DataRow dr in dt.Rows)
                                {
                                    this.cmbDataBase.Items.Add(dr["name"].ToString());
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Bases de datos cargadas", "Padlock", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
                this.cmbDataBase.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al activar el producto: " + this.cmbProduct.Text + "\r\nDescripción: " + ex.Message, "Padlock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtServer.Focus();
            }
        }
    }

    public static class AsymmetricEncryption
    {
        private static bool _optimalAsymmetricEncryptionPadding = false;

        public static void GenerateKeys(int keySize, out string publicKey, out string publicAndPrivateKey)
        {
            using (var provider = new RSACryptoServiceProvider(keySize))
            {
                publicKey = provider.ToXmlString(false);
                publicAndPrivateKey = provider.ToXmlString(true);
            }
        }

        public static string EncryptText(string text, int keySize, string publicKeyXml)
        {
            var encrypted = Encrypt(Encoding.UTF8.GetBytes(text), keySize, publicKeyXml);
            return Convert.ToBase64String(encrypted);
        }

        public static byte[] Encrypt(byte[] data, int keySize, string publicKeyXml)
        {
            if (data == null || data.Length == 0) throw new ArgumentException("Data are empty", "data");
            int maxLength = GetMaxDataLength(keySize);
            if (data.Length > maxLength) throw new ArgumentException(String.Format("Maximum data length is {0}", maxLength), "data");
            if (!IsKeySizeValid(keySize)) throw new ArgumentException("Key size is not valid", "keySize");
            if (String.IsNullOrEmpty(publicKeyXml)) throw new ArgumentException("Key is null or empty", "publicKeyXml");

            using (var provider = new RSACryptoServiceProvider(keySize))
            {
                provider.FromXmlString(publicKeyXml);
                return provider.Encrypt(data, _optimalAsymmetricEncryptionPadding);
            }
        }

        public static string DecryptText(string text, int keySize, string publicAndPrivateKeyXml)
        {
            var decrypted = Decrypt(Convert.FromBase64String(text), keySize, publicAndPrivateKeyXml);
            return Encoding.UTF8.GetString(decrypted);
        }

        public static byte[] Decrypt(byte[] data, int keySize, string publicAndPrivateKeyXml)
        {
            if (data == null || data.Length == 0) throw new ArgumentException("Data are empty", "data");
            if (!IsKeySizeValid(keySize)) throw new ArgumentException("Key size is not valid", "keySize");
            if (String.IsNullOrEmpty(publicAndPrivateKeyXml)) throw new ArgumentException("Key is null or empty", "publicAndPrivateKeyXml");

            using (var provider = new RSACryptoServiceProvider(keySize))
            {
                provider.FromXmlString(publicAndPrivateKeyXml);
                return provider.Decrypt(data, _optimalAsymmetricEncryptionPadding);
            }
        }

        public static int GetMaxDataLength(int keySize)
        {
            if (_optimalAsymmetricEncryptionPadding)
            {
                return ((keySize - 384) / 8) + 7;
            }
            return ((keySize - 384) / 8) + 37;
        }

        public static bool IsKeySizeValid(int keySize)
        {
            return keySize >= 384 &&
                    keySize <= 16384 &&
                    keySize % 8 == 0;
        }
    }
}
