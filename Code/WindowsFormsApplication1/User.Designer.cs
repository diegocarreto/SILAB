namespace WindowsFormsApplication1
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.pbval_txtNewPassword = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbval_txtCurrentPassword = new System.Windows.Forms.PictureBox();
            this.pbval_txtNewRepeatPassword = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtNewPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtNewRepeatPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtCurrentPassword = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtCurrentPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtNewRepeatPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pbval_txtNewPassword
            // 
            this.pbval_txtNewPassword.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtNewPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtNewPassword.Image")));
            this.pbval_txtNewPassword.InitialImage = null;
            this.pbval_txtNewPassword.Location = new System.Drawing.Point(379, 69);
            this.pbval_txtNewPassword.Name = "pbval_txtNewPassword";
            this.pbval_txtNewPassword.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtNewPassword.TabIndex = 39;
            this.pbval_txtNewPassword.TabStop = false;
            this.pbval_txtNewPassword.Tag = "Ingrese su nueva contraseña";
            this.pbval_txtNewPassword.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Contraseña anterior:";
            // 
            // pbval_txtCurrentPassword
            // 
            this.pbval_txtCurrentPassword.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtCurrentPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtCurrentPassword.Image")));
            this.pbval_txtCurrentPassword.InitialImage = null;
            this.pbval_txtCurrentPassword.Location = new System.Drawing.Point(379, 137);
            this.pbval_txtCurrentPassword.Name = "pbval_txtCurrentPassword";
            this.pbval_txtCurrentPassword.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtCurrentPassword.TabIndex = 26;
            this.pbval_txtCurrentPassword.TabStop = false;
            this.pbval_txtCurrentPassword.Tag = "Ingrese su contraseña actual";
            this.pbval_txtCurrentPassword.Visible = false;
            // 
            // pbval_txtNewRepeatPassword
            // 
            this.pbval_txtNewRepeatPassword.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtNewRepeatPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtNewRepeatPassword.Image")));
            this.pbval_txtNewRepeatPassword.InitialImage = null;
            this.pbval_txtNewRepeatPassword.Location = new System.Drawing.Point(379, 98);
            this.pbval_txtNewRepeatPassword.Name = "pbval_txtNewRepeatPassword";
            this.pbval_txtNewRepeatPassword.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtNewRepeatPassword.TabIndex = 25;
            this.pbval_txtNewRepeatPassword.TabStop = false;
            this.pbval_txtNewRepeatPassword.Tag = "Repita su nueva contraseña";
            this.pbval_txtNewRepeatPassword.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nueva contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nueva contraseña:";
            // 
            // btnAccept
            // 
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(217, 171);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "    Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(298, 171);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "    Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtNewPassword
            // 
            // 
            // 
            // 
            this.txtNewPassword.CustomButton.Image = null;
            this.txtNewPassword.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.txtNewPassword.CustomButton.Name = "";
            this.txtNewPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNewPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPassword.CustomButton.TabIndex = 1;
            this.txtNewPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPassword.CustomButton.UseSelectable = true;
            this.txtNewPassword.CustomButton.Visible = false;
            this.txtNewPassword.DisplayIcon = true;
            this.txtNewPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtNewPassword.Icon")));
            this.txtNewPassword.Lines = new string[0];
            this.txtNewPassword.Location = new System.Drawing.Point(113, 63);
            this.txtNewPassword.MaxLength = 32767;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.PromptText = "Introduzca su nueva contraseña";
            this.txtNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.SelectionLength = 0;
            this.txtNewPassword.SelectionStart = 0;
            this.txtNewPassword.ShortcutsEnabled = true;
            this.txtNewPassword.ShowClearButton = true;
            this.txtNewPassword.Size = new System.Drawing.Size(260, 23);
            this.txtNewPassword.TabIndex = 40;
            this.txtNewPassword.UseSelectable = true;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.WaterMark = "Introduzca su nueva contraseña";
            this.txtNewPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNewRepeatPassword
            // 
            // 
            // 
            // 
            this.txtNewRepeatPassword.CustomButton.Image = null;
            this.txtNewRepeatPassword.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.txtNewRepeatPassword.CustomButton.Name = "";
            this.txtNewRepeatPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNewRepeatPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewRepeatPassword.CustomButton.TabIndex = 1;
            this.txtNewRepeatPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewRepeatPassword.CustomButton.UseSelectable = true;
            this.txtNewRepeatPassword.CustomButton.Visible = false;
            this.txtNewRepeatPassword.DisplayIcon = true;
            this.txtNewRepeatPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtNewRepeatPassword.Icon")));
            this.txtNewRepeatPassword.Lines = new string[0];
            this.txtNewRepeatPassword.Location = new System.Drawing.Point(113, 92);
            this.txtNewRepeatPassword.MaxLength = 32767;
            this.txtNewRepeatPassword.Name = "txtNewRepeatPassword";
            this.txtNewRepeatPassword.PasswordChar = '●';
            this.txtNewRepeatPassword.PromptText = "Repita su nueva contraseña";
            this.txtNewRepeatPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewRepeatPassword.SelectedText = "";
            this.txtNewRepeatPassword.SelectionLength = 0;
            this.txtNewRepeatPassword.SelectionStart = 0;
            this.txtNewRepeatPassword.ShortcutsEnabled = true;
            this.txtNewRepeatPassword.ShowClearButton = true;
            this.txtNewRepeatPassword.Size = new System.Drawing.Size(260, 23);
            this.txtNewRepeatPassword.TabIndex = 41;
            this.txtNewRepeatPassword.UseSelectable = true;
            this.txtNewRepeatPassword.UseSystemPasswordChar = true;
            this.txtNewRepeatPassword.WaterMark = "Repita su nueva contraseña";
            this.txtNewRepeatPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewRepeatPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCurrentPassword
            // 
            // 
            // 
            // 
            this.txtCurrentPassword.CustomButton.Image = null;
            this.txtCurrentPassword.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.txtCurrentPassword.CustomButton.Name = "";
            this.txtCurrentPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCurrentPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCurrentPassword.CustomButton.TabIndex = 1;
            this.txtCurrentPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCurrentPassword.CustomButton.UseSelectable = true;
            this.txtCurrentPassword.CustomButton.Visible = false;
            this.txtCurrentPassword.DisplayIcon = true;
            this.txtCurrentPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtCurrentPassword.Icon")));
            this.txtCurrentPassword.Lines = new string[0];
            this.txtCurrentPassword.Location = new System.Drawing.Point(113, 131);
            this.txtCurrentPassword.MaxLength = 32767;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '●';
            this.txtCurrentPassword.PromptText = "Introduzca su contraseña anterior";
            this.txtCurrentPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCurrentPassword.SelectedText = "";
            this.txtCurrentPassword.SelectionLength = 0;
            this.txtCurrentPassword.SelectionStart = 0;
            this.txtCurrentPassword.ShortcutsEnabled = true;
            this.txtCurrentPassword.ShowClearButton = true;
            this.txtCurrentPassword.Size = new System.Drawing.Size(260, 23);
            this.txtCurrentPassword.TabIndex = 42;
            this.txtCurrentPassword.UseSelectable = true;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            this.txtCurrentPassword.WaterMark = "Introduzca su contraseña anterior";
            this.txtCurrentPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCurrentPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 203);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.txtNewRepeatPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.pbval_txtNewPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbval_txtCurrentPassword);
            this.Controls.Add(this.pbval_txtNewRepeatPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User";
            this.Text = "Cambiar contraseña";
            this.Load += new System.EventHandler(this.Config_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtCurrentPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtNewRepeatPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbval_txtNewRepeatPassword;
        private System.Windows.Forms.PictureBox pbval_txtCurrentPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbval_txtNewPassword;
        private MetroFramework.Controls.MetroTextBox txtNewPassword;
        private MetroFramework.Controls.MetroTextBox txtNewRepeatPassword;
        private MetroFramework.Controls.MetroTextBox txtCurrentPassword;
    }
}