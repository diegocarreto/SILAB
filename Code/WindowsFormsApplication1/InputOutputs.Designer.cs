namespace WindowsFormsApplication1
{
    partial class InputOutputs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputOutputs));
            this.pbval_txtDescription = new System.Windows.Forms.PictureBox();
            this.pbval_txtAmount = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.pbval_cmbType = new System.Windows.Forms.PictureBox();
            this.pbval_txtName = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.txtAmount = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_cmbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbval_txtDescription
            // 
            this.pbval_txtDescription.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtDescription.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtDescription.Image")));
            this.pbval_txtDescription.InitialImage = null;
            this.pbval_txtDescription.Location = new System.Drawing.Point(282, 148);
            this.pbval_txtDescription.Name = "pbval_txtDescription";
            this.pbval_txtDescription.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtDescription.TabIndex = 89;
            this.pbval_txtDescription.TabStop = false;
            this.pbval_txtDescription.Tag = "Ingrese la descripcion";
            this.pbval_txtDescription.Visible = false;
            // 
            // pbval_txtAmount
            // 
            this.pbval_txtAmount.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtAmount.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtAmount.Image")));
            this.pbval_txtAmount.InitialImage = null;
            this.pbval_txtAmount.Location = new System.Drawing.Point(282, 123);
            this.pbval_txtAmount.Name = "pbval_txtAmount";
            this.pbval_txtAmount.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtAmount.TabIndex = 88;
            this.pbval_txtAmount.TabStop = false;
            this.pbval_txtAmount.Tag = "Ingrese el monto";
            this.pbval_txtAmount.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Tipo:";
            // 
            // cmbType
            // 
            this.cmbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Seleccione...",
            "Ingreso",
            "Egreso"});
            this.cmbType.Location = new System.Drawing.Point(78, 63);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(198, 21);
            this.cmbType.TabIndex = 0;
            // 
            // pbval_cmbType
            // 
            this.pbval_cmbType.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_cmbType.Image = ((System.Drawing.Image)(resources.GetObject("pbval_cmbType.Image")));
            this.pbval_cmbType.InitialImage = null;
            this.pbval_cmbType.Location = new System.Drawing.Point(282, 66);
            this.pbval_cmbType.Name = "pbval_cmbType";
            this.pbval_cmbType.Size = new System.Drawing.Size(18, 17);
            this.pbval_cmbType.TabIndex = 26;
            this.pbval_cmbType.TabStop = false;
            this.pbval_cmbType.Tag = "Indique el tipo";
            this.pbval_cmbType.Visible = false;
            // 
            // pbval_txtName
            // 
            this.pbval_txtName.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtName.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtName.Image")));
            this.pbval_txtName.InitialImage = null;
            this.pbval_txtName.Location = new System.Drawing.Point(282, 93);
            this.pbval_txtName.Name = "pbval_txtName";
            this.pbval_txtName.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtName.TabIndex = 25;
            this.pbval_txtName.TabStop = false;
            this.pbval_txtName.Tag = "Ingrese el nombre";
            this.pbval_txtName.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Monto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 97);
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
            this.btnAccept.Location = new System.Drawing.Point(120, 402);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "    Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(201, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
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
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(96, 2);
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
            this.txtDescription.Location = new System.Drawing.Point(78, 148);
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
            this.txtDescription.Size = new System.Drawing.Size(198, 104);
            this.txtDescription.TabIndex = 3;
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
            this.txtAmount.CustomButton.Location = new System.Drawing.Point(176, 1);
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
            this.txtAmount.Location = new System.Drawing.Point(78, 118);
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
            this.txtAmount.Size = new System.Drawing.Size(198, 23);
            this.txtAmount.TabIndex = 2;
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
            this.txtName.CustomButton.Location = new System.Drawing.Point(176, 1);
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
            this.txtName.Location = new System.Drawing.Point(78, 89);
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
            this.txtName.Size = new System.Drawing.Size(198, 23);
            this.txtName.TabIndex = 1;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Introduzca el nombre";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pbPhoto
            // 
            this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPhoto.Location = new System.Drawing.Point(78, 258);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(198, 138);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 90;
            this.pbPhoto.TabStop = false;
            this.pbPhoto.Click += new System.EventHandler(this.pbPhoto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "Imagen:";
            // 
            // InputOutputs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 433);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.pbval_txtDescription);
            this.Controls.Add(this.pbval_txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.pbval_cmbType);
            this.Controls.Add(this.pbval_txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputOutputs";
            this.Text = "Ingreso y Egreso";
            this.Load += new System.EventHandler(this.Habitant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_cmbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbval_txtName;
        private System.Windows.Forms.PictureBox pbval_cmbType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbval_txtAmount;
        private System.Windows.Forms.PictureBox pbval_txtDescription;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroTextBox txtAmount;
        private MetroFramework.Controls.MetroTextBox txtName;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Label label5;
    }
}