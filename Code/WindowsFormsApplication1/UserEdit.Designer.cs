namespace WindowsFormsApplication1
{
    partial class UserEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEdit));
            this.btnBiometric = new System.Windows.Forms.Button();
            this.txtNewRepeatPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtNewPassword = new MetroFramework.Controls.MetroTextBox();
            this.pbval_txtNewPassword = new System.Windows.Forms.PictureBox();
            this.pbval_txtNewRepeatPassword = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlias = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.pbVal_cmbRol = new System.Windows.Forms.PictureBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbval_txtAlias = new System.Windows.Forms.PictureBox();
            this.pbval_txtName = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbUsePassword = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbBiometric = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtNewRepeatPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtAlias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtName)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBiometric
            // 
            this.btnBiometric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBiometric.Image = ((System.Drawing.Image)(resources.GetObject("btnBiometric.Image")));
            this.btnBiometric.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBiometric.Location = new System.Drawing.Point(69, 241);
            this.btnBiometric.Name = "btnBiometric";
            this.btnBiometric.Size = new System.Drawing.Size(83, 23);
            this.btnBiometric.TabIndex = 110;
            this.btnBiometric.Text = "    Biometrico";
            this.btnBiometric.UseVisualStyleBackColor = true;
            this.btnBiometric.Click += new System.EventHandler(this.btnBiometric_Click);
            // 
            // txtNewRepeatPassword
            // 
            // 
            // 
            // 
            this.txtNewRepeatPassword.CustomButton.Image = null;
            this.txtNewRepeatPassword.CustomButton.Location = new System.Drawing.Point(222, 1);
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
            this.txtNewRepeatPassword.Location = new System.Drawing.Point(69, 175);
            this.txtNewRepeatPassword.MaxLength = 32767;
            this.txtNewRepeatPassword.Name = "txtNewRepeatPassword";
            this.txtNewRepeatPassword.PasswordChar = '●';
            this.txtNewRepeatPassword.PromptText = "Repita la contraseña";
            this.txtNewRepeatPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewRepeatPassword.SelectedText = "";
            this.txtNewRepeatPassword.SelectionLength = 0;
            this.txtNewRepeatPassword.SelectionStart = 0;
            this.txtNewRepeatPassword.ShortcutsEnabled = true;
            this.txtNewRepeatPassword.ShowClearButton = true;
            this.txtNewRepeatPassword.Size = new System.Drawing.Size(244, 23);
            this.txtNewRepeatPassword.TabIndex = 4;
            this.txtNewRepeatPassword.UseSelectable = true;
            this.txtNewRepeatPassword.UseSystemPasswordChar = true;
            this.txtNewRepeatPassword.WaterMark = "Repita la contraseña";
            this.txtNewRepeatPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewRepeatPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNewPassword
            // 
            // 
            // 
            // 
            this.txtNewPassword.CustomButton.Image = null;
            this.txtNewPassword.CustomButton.Location = new System.Drawing.Point(222, 1);
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
            this.txtNewPassword.Location = new System.Drawing.Point(69, 146);
            this.txtNewPassword.MaxLength = 32767;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.PromptText = "Introduzca la contraseña";
            this.txtNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.SelectionLength = 0;
            this.txtNewPassword.SelectionStart = 0;
            this.txtNewPassword.ShortcutsEnabled = true;
            this.txtNewPassword.ShowClearButton = true;
            this.txtNewPassword.Size = new System.Drawing.Size(244, 23);
            this.txtNewPassword.TabIndex = 3;
            this.txtNewPassword.UseSelectable = true;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.WaterMark = "Introduzca la contraseña";
            this.txtNewPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pbval_txtNewPassword
            // 
            this.pbval_txtNewPassword.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtNewPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtNewPassword.Image")));
            this.pbval_txtNewPassword.InitialImage = null;
            this.pbval_txtNewPassword.Location = new System.Drawing.Point(319, 146);
            this.pbval_txtNewPassword.Name = "pbval_txtNewPassword";
            this.pbval_txtNewPassword.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtNewPassword.TabIndex = 109;
            this.pbval_txtNewPassword.TabStop = false;
            this.pbval_txtNewPassword.Tag = "Introduzca la contraseña";
            this.pbval_txtNewPassword.Visible = false;
            // 
            // pbval_txtNewRepeatPassword
            // 
            this.pbval_txtNewRepeatPassword.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtNewRepeatPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtNewRepeatPassword.Image")));
            this.pbval_txtNewRepeatPassword.InitialImage = null;
            this.pbval_txtNewRepeatPassword.Location = new System.Drawing.Point(319, 175);
            this.pbval_txtNewRepeatPassword.Name = "pbval_txtNewRepeatPassword";
            this.pbval_txtNewRepeatPassword.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtNewRepeatPassword.TabIndex = 108;
            this.pbval_txtNewRepeatPassword.TabStop = false;
            this.pbval_txtNewRepeatPassword.Tag = "Repita la contraseña";
            this.pbval_txtNewRepeatPassword.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 107;
            this.label3.Text = "Repita:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 106;
            this.label4.Text = "Contraseña:";
            // 
            // txtAlias
            // 
            // 
            // 
            // 
            this.txtAlias.CustomButton.Image = null;
            this.txtAlias.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtAlias.CustomButton.Name = "";
            this.txtAlias.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAlias.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAlias.CustomButton.TabIndex = 1;
            this.txtAlias.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAlias.CustomButton.UseSelectable = true;
            this.txtAlias.CustomButton.Visible = false;
            this.txtAlias.DisplayIcon = true;
            this.txtAlias.Icon = ((System.Drawing.Image)(resources.GetObject("txtAlias.Icon")));
            this.txtAlias.Lines = new string[0];
            this.txtAlias.Location = new System.Drawing.Point(69, 90);
            this.txtAlias.MaxLength = 32767;
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.PasswordChar = '\0';
            this.txtAlias.PromptText = "Introduzca el alias";
            this.txtAlias.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAlias.SelectedText = "";
            this.txtAlias.SelectionLength = 0;
            this.txtAlias.SelectionStart = 0;
            this.txtAlias.ShortcutsEnabled = true;
            this.txtAlias.ShowClearButton = true;
            this.txtAlias.Size = new System.Drawing.Size(244, 23);
            this.txtAlias.TabIndex = 1;
            this.txtAlias.UseSelectable = true;
            this.txtAlias.WaterMark = "Introduzca el alias";
            this.txtAlias.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAlias.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.DisplayIcon = true;
            this.txtName.Icon = ((System.Drawing.Image)(resources.GetObject("txtName.Icon")));
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(69, 63);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Introduzca el nombre";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.ShowClearButton = true;
            this.txtName.Size = new System.Drawing.Size(244, 23);
            this.txtName.TabIndex = 0;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Introduzca el nombre";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pbVal_cmbRol
            // 
            this.pbVal_cmbRol.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbVal_cmbRol.Image = ((System.Drawing.Image)(resources.GetObject("pbVal_cmbRol.Image")));
            this.pbVal_cmbRol.InitialImage = null;
            this.pbVal_cmbRol.Location = new System.Drawing.Point(319, 117);
            this.pbVal_cmbRol.Name = "pbVal_cmbRol";
            this.pbVal_cmbRol.Size = new System.Drawing.Size(18, 17);
            this.pbVal_cmbRol.TabIndex = 105;
            this.pbVal_cmbRol.TabStop = false;
            this.pbVal_cmbRol.Tag = "Indique el rol";
            this.pbVal_cmbRol.Visible = false;
            // 
            // cmbRol
            // 
            this.cmbRol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbRol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(69, 119);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(244, 21);
            this.cmbRol.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 103;
            this.label7.Text = "Rol:";
            // 
            // pbval_txtAlias
            // 
            this.pbval_txtAlias.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtAlias.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtAlias.Image")));
            this.pbval_txtAlias.InitialImage = null;
            this.pbval_txtAlias.Location = new System.Drawing.Point(319, 90);
            this.pbval_txtAlias.Name = "pbval_txtAlias";
            this.pbval_txtAlias.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtAlias.TabIndex = 26;
            this.pbval_txtAlias.TabStop = false;
            this.pbval_txtAlias.Tag = "Ingrese el alias";
            this.pbval_txtAlias.Visible = false;
            // 
            // pbval_txtName
            // 
            this.pbval_txtName.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtName.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtName.Image")));
            this.pbval_txtName.InitialImage = null;
            this.pbval_txtName.Location = new System.Drawing.Point(319, 63);
            this.pbval_txtName.Name = "pbval_txtName";
            this.pbval_txtName.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtName.TabIndex = 25;
            this.pbval_txtName.TabStop = false;
            this.pbval_txtName.Tag = "Ingrese el nombre";
            this.pbval_txtName.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Activo:";
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Checked = true;
            this.cbActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbActive.Location = new System.Drawing.Point(235, 211);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(15, 14);
            this.cbActive.TabIndex = 5;
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Alias:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre:";
            // 
            // btnAccept
            // 
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(157, 241);
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
            this.btnExit.Location = new System.Drawing.Point(238, 241);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "    Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 112;
            this.label6.Text = "Contraseña:";
            // 
            // cbUsePassword
            // 
            this.cbUsePassword.AutoSize = true;
            this.cbUsePassword.Checked = true;
            this.cbUsePassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUsePassword.Location = new System.Drawing.Point(69, 210);
            this.cbUsePassword.Name = "cbUsePassword";
            this.cbUsePassword.Size = new System.Drawing.Size(15, 14);
            this.cbUsePassword.TabIndex = 111;
            this.cbUsePassword.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 113;
            this.label8.Text = "Biometrico:";
            // 
            // cbBiometric
            // 
            this.cbBiometric.AutoSize = true;
            this.cbBiometric.Checked = true;
            this.cbBiometric.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBiometric.Location = new System.Drawing.Point(152, 211);
            this.cbBiometric.Name = "cbBiometric";
            this.cbBiometric.Size = new System.Drawing.Size(15, 14);
            this.cbBiometric.TabIndex = 114;
            this.cbBiometric.UseVisualStyleBackColor = true;
            // 
            // UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 278);
            this.Controls.Add(this.cbBiometric);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbUsePassword);
            this.Controls.Add(this.btnBiometric);
            this.Controls.Add(this.txtNewRepeatPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.pbval_txtNewPassword);
            this.Controls.Add(this.pbval_txtNewRepeatPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pbVal_cmbRol);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbval_txtAlias);
            this.Controls.Add(this.pbval_txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserEdit";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Habitant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtNewRepeatPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtAlias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbval_txtName;
        private System.Windows.Forms.PictureBox pbval_txtAlias;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtAlias;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbVal_cmbRol;
        private MetroFramework.Controls.MetroTextBox txtNewRepeatPassword;
        private MetroFramework.Controls.MetroTextBox txtNewPassword;
        private System.Windows.Forms.PictureBox pbval_txtNewPassword;
        private System.Windows.Forms.PictureBox pbval_txtNewRepeatPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBiometric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbUsePassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbBiometric;
    }
}