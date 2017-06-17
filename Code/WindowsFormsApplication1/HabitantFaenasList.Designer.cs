namespace WindowsFormsApplication1
{
    partial class HabitantFaenasList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HabitantFaenasList));
            this.gvList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HabitantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aux2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HabitantDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaenaDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aux = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtpDate1 = new System.Windows.Forms.DateTimePicker();
            this.dtpDate2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFind = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pageList = new WindowsFormsApplication1.Pager();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvList
            // 
            this.gvList.AllowUserToAddRows = false;
            this.gvList.AllowUserToDeleteRows = false;
            this.gvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.HabitantName,
            this.Name,
            this.Description,
            this.Amount,
            this.Aux2,
            this.HabitantDate,
            this.FaenaDate,
            this.CreationDate,
            this.Aux});
            this.gvList.Location = new System.Drawing.Point(12, 121);
            this.gvList.Name = "gvList";
            this.gvList.ReadOnly = true;
            this.gvList.Size = new System.Drawing.Size(1198, 361);
            this.gvList.TabIndex = 13;
            this.gvList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvList_CellMouseDoubleClick);
            this.gvList.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvList_CellMouseLeave);
            this.gvList.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvList_CellMouseMove);
            this.gvList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvList_ColumnHeaderMouseClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // HabitantName
            // 
            this.HabitantName.DataPropertyName = "habitantName";
            this.HabitantName.HeaderText = "Habitante";
            this.HabitantName.Name = "HabitantName";
            this.HabitantName.ReadOnly = true;
            this.HabitantName.Width = 150;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "name";
            this.Name.HeaderText = "Nombre";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "description";
            this.Description.HeaderText = "Descripción";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 230;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "amount";
            dataGridViewCellStyle1.Format = "N2";
            this.Amount.DefaultCellStyle = dataGridViewCellStyle1;
            this.Amount.HeaderText = "Monto";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Aux2
            // 
            this.Aux2.DataPropertyName = "aux2";
            this.Aux2.HeaderText = "Siempre";
            this.Aux2.Name = "Aux2";
            this.Aux2.ReadOnly = true;
            this.Aux2.Width = 60;
            // 
            // HabitantDate
            // 
            this.HabitantDate.DataPropertyName = "habitantDate";
            this.HabitantDate.HeaderText = "Alta Habitante";
            this.HabitantDate.Name = "HabitantDate";
            this.HabitantDate.ReadOnly = true;
            this.HabitantDate.Width = 120;
            // 
            // FaenaDate
            // 
            this.FaenaDate.DataPropertyName = "faenaDate";
            this.FaenaDate.HeaderText = "Alta Cooperacion";
            this.FaenaDate.Name = "FaenaDate";
            this.FaenaDate.ReadOnly = true;
            this.FaenaDate.Width = 120;
            // 
            // CreationDate
            // 
            this.CreationDate.DataPropertyName = "CreationDate";
            this.CreationDate.HeaderText = "Alta";
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.ReadOnly = true;
            this.CreationDate.Width = 130;
            // 
            // Aux
            // 
            this.Aux.DataPropertyName = "Aux";
            this.Aux.HeaderText = "Imprimir";
            this.Aux.Name = "Aux";
            this.Aux.ReadOnly = true;
            this.Aux.Width = 60;
            // 
            // btnNew
            // 
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(973, 488);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "    Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(1054, 488);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Cancelar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1135, 488);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "    Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtpDate1
            // 
            this.dtpDate1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDate1.Location = new System.Drawing.Point(77, 92);
            this.dtpDate1.Name = "dtpDate1";
            this.dtpDate1.Size = new System.Drawing.Size(114, 20);
            this.dtpDate1.TabIndex = 61;
            this.dtpDate1.ValueChanged += new System.EventHandler(this.dtpDate1_ValueChanged);
            // 
            // dtpDate2
            // 
            this.dtpDate2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDate2.Location = new System.Drawing.Point(236, 92);
            this.dtpDate2.Name = "dtpDate2";
            this.dtpDate2.Size = new System.Drawing.Size(114, 20);
            this.dtpDate2.TabIndex = 62;
            this.dtpDate2.ValueChanged += new System.EventHandler(this.dtpDate2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Fin:";
            // 
            // txtFind
            // 
            // 
            // 
            // 
            this.txtFind.CustomButton.Image = null;
            this.txtFind.CustomButton.Location = new System.Drawing.Point(1111, 1);
            this.txtFind.CustomButton.Name = "";
            this.txtFind.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFind.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFind.CustomButton.TabIndex = 1;
            this.txtFind.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFind.CustomButton.UseSelectable = true;
            this.txtFind.CustomButton.Visible = false;
            this.txtFind.DisplayIcon = true;
            this.txtFind.Icon = ((System.Drawing.Image)(resources.GetObject("txtFind.Icon")));
            this.txtFind.Lines = new string[0];
            this.txtFind.Location = new System.Drawing.Point(77, 63);
            this.txtFind.MaxLength = 32767;
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.PromptText = "Introduzca su búsqueda";
            this.txtFind.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFind.SelectedText = "";
            this.txtFind.SelectionLength = 0;
            this.txtFind.SelectionStart = 0;
            this.txtFind.ShortcutsEnabled = true;
            this.txtFind.ShowClearButton = true;
            this.txtFind.Size = new System.Drawing.Size(1133, 23);
            this.txtFind.TabIndex = 111;
            this.txtFind.UseSelectable = true;
            this.txtFind.WaterMark = "Introduzca su búsqueda";
            this.txtFind.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFind.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyUp_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 110;
            this.label5.Text = "Busqueda:";
            // 
            // pageList
            // 
            this.pageList.Location = new System.Drawing.Point(12, 488);
            this.pageList.Name = "pageList";
            this.pageList.Size = new System.Drawing.Size(396, 30);
            this.pageList.TabIndex = 112;
            // 
            // HabitantFaenasList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 530);
            this.Controls.Add(this.pageList);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDate2);
            this.Controls.Add(this.dtpDate1);
            this.Controls.Add(this.gvList);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Tag = "HabitantFaenasList";
            this.Text = "Cooperaciones";
            this.Load += new System.EventHandler(this.HabitantList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvList;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtpDate1;
        private System.Windows.Forms.DateTimePicker dtpDate2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtFind;
        private System.Windows.Forms.Label label5;
        private Pager pageList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn HabitantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aux2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HabitantDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaenaDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aux;
    }
}