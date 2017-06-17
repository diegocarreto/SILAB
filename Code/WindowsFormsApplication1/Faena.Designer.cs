namespace WindowsFormsApplication1
{
    partial class Faena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faena));
            this.pbVal_cmbMonth = new System.Windows.Forms.PictureBox();
            this.pbVal_cmbYear = new System.Windows.Forms.PictureBox();
            this.pbval_txtDescription = new System.Windows.Forms.PictureBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAlways = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbval_txtAmount = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbval_txtName = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.txtAmount = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtName)).BeginInit();
            this.SuspendLayout();
            // 
            // pbVal_cmbMonth
            // 
            this.pbVal_cmbMonth.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbVal_cmbMonth.Image = ((System.Drawing.Image)(resources.GetObject("pbVal_cmbMonth.Image")));
            this.pbVal_cmbMonth.InitialImage = null;
            this.pbVal_cmbMonth.Location = new System.Drawing.Point(286, 141);
            this.pbVal_cmbMonth.Name = "pbVal_cmbMonth";
            this.pbVal_cmbMonth.Size = new System.Drawing.Size(18, 17);
            this.pbVal_cmbMonth.TabIndex = 100;
            this.pbVal_cmbMonth.TabStop = false;
            this.pbVal_cmbMonth.Tag = "Indique el mes inicial";
            this.pbVal_cmbMonth.Visible = false;
            // 
            // pbVal_cmbYear
            // 
            this.pbVal_cmbYear.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbVal_cmbYear.Image = ((System.Drawing.Image)(resources.GetObject("pbVal_cmbYear.Image")));
            this.pbVal_cmbYear.InitialImage = null;
            this.pbVal_cmbYear.Location = new System.Drawing.Point(286, 118);
            this.pbVal_cmbYear.Name = "pbVal_cmbYear";
            this.pbVal_cmbYear.Size = new System.Drawing.Size(18, 17);
            this.pbVal_cmbYear.TabIndex = 99;
            this.pbVal_cmbYear.TabStop = false;
            this.pbVal_cmbYear.Tag = "Indique el año inicial";
            this.pbVal_cmbYear.Visible = false;
            // 
            // pbval_txtDescription
            // 
            this.pbval_txtDescription.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtDescription.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtDescription.Image")));
            this.pbval_txtDescription.InitialImage = null;
            this.pbval_txtDescription.Location = new System.Drawing.Point(286, 168);
            this.pbval_txtDescription.Name = "pbval_txtDescription";
            this.pbval_txtDescription.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtDescription.TabIndex = 98;
            this.pbval_txtDescription.TabStop = false;
            this.pbval_txtDescription.Tag = "Ingrese la descripcion";
            this.pbval_txtDescription.Visible = false;
            // 
            // cmbMonth
            // 
            this.cmbMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(85, 142);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(196, 21);
            this.cmbMonth.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 96;
            this.label6.Text = "Mes Inicial:";
            // 
            // cmbYear
            // 
            this.cmbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(85, 115);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(195, 21);
            this.cmbYear.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 94;
            this.label7.Text = "Año Inicial:";
            // 
            // cbAlways
            // 
            this.cbAlways.AutoSize = true;
            this.cbAlways.Location = new System.Drawing.Point(167, 279);
            this.cbAlways.Name = "cbAlways";
            this.cbAlways.Size = new System.Drawing.Size(15, 14);
            this.cbAlways.TabIndex = 6;
            this.cbAlways.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "Siempre:";
            // 
            // pbval_txtAmount
            // 
            this.pbval_txtAmount.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtAmount.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtAmount.Image")));
            this.pbval_txtAmount.InitialImage = null;
            this.pbval_txtAmount.Location = new System.Drawing.Point(286, 92);
            this.pbval_txtAmount.Name = "pbval_txtAmount";
            this.pbval_txtAmount.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtAmount.TabIndex = 91;
            this.pbval_txtAmount.TabStop = false;
            this.pbval_txtAmount.Tag = "Ingrese el monto";
            this.pbval_txtAmount.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Monto:";
            // 
            // pbval_txtName
            // 
            this.pbval_txtName.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtName.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtName.Image")));
            this.pbval_txtName.InitialImage = null;
            this.pbval_txtName.Location = new System.Drawing.Point(286, 62);
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
            this.label5.Location = new System.Drawing.Point(39, 279);
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
            this.cbActive.Location = new System.Drawing.Point(85, 279);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(15, 14);
            this.cbActive.TabIndex = 5;
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 66);
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
            this.btnAccept.Location = new System.Drawing.Point(124, 300);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Text = "    Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(205, 300);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "    Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(93, 2);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(99, 99);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.DisplayIcon = true;
            this.txtDescription.Icon = ((System.Drawing.Image)(resources.GetObject("txtDescription.Icon")));
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(85, 168);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PromptText = "Introduzca la descripción";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.ShowClearButton = true;
            this.txtDescription.Size = new System.Drawing.Size(195, 104);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMark = "Introduzca la descripción";
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.CustomButton.Image = null;
            this.txtAmount.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.txtAmount.CustomButton.Name = "";
            this.txtAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmount.CustomButton.TabIndex = 1;
            this.txtAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmount.CustomButton.UseSelectable = true;
            this.txtAmount.CustomButton.Visible = false;
            this.txtAmount.DisplayIcon = true;
            this.txtAmount.Icon = ((System.Drawing.Image)(resources.GetObject("txtAmount.Icon")));
            this.txtAmount.Lines = new string[0];
            this.txtAmount.Location = new System.Drawing.Point(85, 86);
            this.txtAmount.MaxLength = 32767;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PromptText = "Introduzca el monto";
            this.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.ShortcutsEnabled = true;
            this.txtAmount.ShowClearButton = true;
            this.txtAmount.Size = new System.Drawing.Size(195, 23);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.Tag = "txtMoney";
            this.txtAmount.UseSelectable = true;
            this.txtAmount.WaterMark = "Introduzca el monto";
            this.txtAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(173, 1);
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
            this.txtName.Location = new System.Drawing.Point(85, 57);
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
            this.txtName.Size = new System.Drawing.Size(195, 23);
            this.txtName.TabIndex = 0;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Introduzca el nombre";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Faena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 335);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.pbVal_cmbMonth);
            this.Controls.Add(this.pbVal_cmbYear);
            this.Controls.Add(this.pbval_txtDescription);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbAlways);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbval_txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbval_txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbActive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Faena";
            this.Text = "Cooperaciones";
            this.Load += new System.EventHandler(this.Habitant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbval_txtName;
        private System.Windows.Forms.PictureBox pbval_txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAlways;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbval_txtDescription;
        private System.Windows.Forms.PictureBox pbVal_cmbYear;
        private System.Windows.Forms.PictureBox pbVal_cmbMonth;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroTextBox txtAmount;
        private MetroFramework.Controls.MetroTextBox txtName;
    }
}