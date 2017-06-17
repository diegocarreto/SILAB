namespace WindowsFormsApplication1
{
    partial class BranchOfficeEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BranchOfficeEdit));
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.pbval_txtName = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtManager = new MetroFramework.Controls.MetroTextBox();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.pbval_txtCode = new System.Windows.Forms.PictureBox();
            this.pbval_txtPhone = new System.Windows.Forms.PictureBox();
            this.pbval_txtManager = new System.Windows.Forms.PictureBox();
            this.pbval_txtAddress = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtAddress)).BeginInit();
            this.SuspendLayout();
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
            this.txtName.Location = new System.Drawing.Point(67, 93);
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
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "{\"entity\":\"Name\"}";
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Introduzca el nombre";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pbval_txtName
            // 
            this.pbval_txtName.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtName.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtName.Image")));
            this.pbval_txtName.InitialImage = null;
            this.pbval_txtName.Location = new System.Drawing.Point(316, 99);
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
            this.label5.Location = new System.Drawing.Point(23, 303);
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
            this.cbActive.Location = new System.Drawing.Point(67, 302);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(15, 14);
            this.cbActive.TabIndex = 5;
            this.cbActive.Tag = "{\"entity\":\"Active\"}";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 103);
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
            this.btnAccept.Location = new System.Drawing.Point(154, 316);
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
            this.btnExit.Location = new System.Drawing.Point(235, 316);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "    Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Gerente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Teléfono:";
            // 
            // txtCode
            // 
            // 
            // 
            // 
            this.txtCode.CustomButton.Image = null;
            this.txtCode.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtCode.CustomButton.Name = "";
            this.txtCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCode.CustomButton.TabIndex = 1;
            this.txtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCode.CustomButton.UseSelectable = true;
            this.txtCode.CustomButton.Visible = false;
            this.txtCode.DisplayIcon = true;
            this.txtCode.Icon = ((System.Drawing.Image)(resources.GetObject("txtCode.Icon")));
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(66, 63);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.PromptText = "Introduzca el código";
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.SelectionLength = 0;
            this.txtCode.SelectionStart = 0;
            this.txtCode.ShortcutsEnabled = true;
            this.txtCode.ShowClearButton = true;
            this.txtCode.Size = new System.Drawing.Size(244, 23);
            this.txtCode.TabIndex = 0;
            this.txtCode.Tag = "{\"entity\":\"IternalCode\"}";
            this.txtCode.UseSelectable = true;
            this.txtCode.WaterMark = "Introduzca el código";
            this.txtCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.DisplayIcon = true;
            this.txtPhone.Icon = ((System.Drawing.Image)(resources.GetObject("txtPhone.Icon")));
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(66, 122);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PromptText = "Introduzca el teléfono";
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.ShowClearButton = true;
            this.txtPhone.Size = new System.Drawing.Size(244, 23);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.Tag = "{\"entity\":\"Phone\"}";
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMark = "Introduzca el teléfono";
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtManager
            // 
            // 
            // 
            // 
            this.txtManager.CustomButton.Image = null;
            this.txtManager.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtManager.CustomButton.Name = "";
            this.txtManager.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtManager.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtManager.CustomButton.TabIndex = 1;
            this.txtManager.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtManager.CustomButton.UseSelectable = true;
            this.txtManager.CustomButton.Visible = false;
            this.txtManager.DisplayIcon = true;
            this.txtManager.Icon = ((System.Drawing.Image)(resources.GetObject("txtManager.Icon")));
            this.txtManager.Lines = new string[0];
            this.txtManager.Location = new System.Drawing.Point(66, 151);
            this.txtManager.MaxLength = 32767;
            this.txtManager.Name = "txtManager";
            this.txtManager.PasswordChar = '\0';
            this.txtManager.PromptText = "Introduzca el gerente";
            this.txtManager.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtManager.SelectedText = "";
            this.txtManager.SelectionLength = 0;
            this.txtManager.SelectionStart = 0;
            this.txtManager.ShortcutsEnabled = true;
            this.txtManager.ShowClearButton = true;
            this.txtManager.Size = new System.Drawing.Size(244, 23);
            this.txtManager.TabIndex = 3;
            this.txtManager.Tag = "{\"entity\":\"Manager\"}";
            this.txtManager.UseSelectable = true;
            this.txtManager.WaterMark = "Introduzca el gerente";
            this.txtManager.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtManager.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(130, 2);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(111, 111);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.DisplayIcon = true;
            this.txtAddress.Icon = ((System.Drawing.Image)(resources.GetObject("txtAddress.Icon")));
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(67, 180);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PromptText = "Introduzca la dirección";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.ShowClearButton = true;
            this.txtAddress.Size = new System.Drawing.Size(244, 116);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.Tag = "{\"entity\":\"Address\"}";
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMark = "Introduzca la dirección";
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pbval_txtCode
            // 
            this.pbval_txtCode.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtCode.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtCode.Image")));
            this.pbval_txtCode.InitialImage = null;
            this.pbval_txtCode.Location = new System.Drawing.Point(316, 69);
            this.pbval_txtCode.Name = "pbval_txtCode";
            this.pbval_txtCode.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtCode.TabIndex = 33;
            this.pbval_txtCode.TabStop = false;
            this.pbval_txtCode.Tag = "Ingrese el código";
            this.pbval_txtCode.Visible = false;
            // 
            // pbval_txtPhone
            // 
            this.pbval_txtPhone.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtPhone.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtPhone.Image")));
            this.pbval_txtPhone.InitialImage = null;
            this.pbval_txtPhone.Location = new System.Drawing.Point(316, 128);
            this.pbval_txtPhone.Name = "pbval_txtPhone";
            this.pbval_txtPhone.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtPhone.TabIndex = 34;
            this.pbval_txtPhone.TabStop = false;
            this.pbval_txtPhone.Tag = "Ingrese el teléfono";
            this.pbval_txtPhone.Visible = false;
            // 
            // pbval_txtManager
            // 
            this.pbval_txtManager.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtManager.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtManager.Image")));
            this.pbval_txtManager.InitialImage = null;
            this.pbval_txtManager.Location = new System.Drawing.Point(316, 157);
            this.pbval_txtManager.Name = "pbval_txtManager";
            this.pbval_txtManager.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtManager.TabIndex = 35;
            this.pbval_txtManager.TabStop = false;
            this.pbval_txtManager.Tag = "Ingrese el gerente";
            this.pbval_txtManager.Visible = false;
            // 
            // pbval_txtAddress
            // 
            this.pbval_txtAddress.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtAddress.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtAddress.Image")));
            this.pbval_txtAddress.InitialImage = null;
            this.pbval_txtAddress.Location = new System.Drawing.Point(316, 184);
            this.pbval_txtAddress.Name = "pbval_txtAddress";
            this.pbval_txtAddress.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtAddress.TabIndex = 36;
            this.pbval_txtAddress.TabStop = false;
            this.pbval_txtAddress.Tag = "Ingrese la dirección";
            this.pbval_txtAddress.Visible = false;
            // 
            // BranchOfficeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 349);
            this.Controls.Add(this.pbval_txtAddress);
            this.Controls.Add(this.pbval_txtManager);
            this.Controls.Add(this.pbval_txtPhone);
            this.Controls.Add(this.pbval_txtCode);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtManager);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pbval_txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbActive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BranchOfficeEdit";
            this.Text = "Sucursal";
            this.Load += new System.EventHandler(this.Habitant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbval_txtName;
        private MetroFramework.Controls.MetroTextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox txtCode;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroTextBox txtManager;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private System.Windows.Forms.PictureBox pbval_txtCode;
        private System.Windows.Forms.PictureBox pbval_txtPhone;
        private System.Windows.Forms.PictureBox pbval_txtManager;
        private System.Windows.Forms.PictureBox pbval_txtAddress;
    }
}