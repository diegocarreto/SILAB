namespace WindowsFormsApplication1
{
    partial class HabitantList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HabitantList));
            this.gvList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aux = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aux2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Printbtn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFind = new MetroFramework.Controls.MetroTextBox();
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
            this.Name,
            this.Paterno,
            this.Materno,
            this.Observations,
            this.Year,
            this.MonthName,
            this.Total,
            this.Aux,
            this.Aux2,
            this.Printbtn});
            this.gvList.Location = new System.Drawing.Point(21, 92);
            this.gvList.Name = "gvList";
            this.gvList.ReadOnly = true;
            this.gvList.Size = new System.Drawing.Size(1103, 365);
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
            // Name
            // 
            this.Name.DataPropertyName = "name";
            this.Name.HeaderText = "Nombre";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Paterno
            // 
            this.Paterno.DataPropertyName = "paterno";
            this.Paterno.HeaderText = "Paterno";
            this.Paterno.Name = "Paterno";
            this.Paterno.ReadOnly = true;
            // 
            // Materno
            // 
            this.Materno.DataPropertyName = "materno";
            this.Materno.HeaderText = "Materno";
            this.Materno.Name = "Materno";
            this.Materno.ReadOnly = true;
            // 
            // Observations
            // 
            this.Observations.DataPropertyName = "observations";
            this.Observations.HeaderText = "Observaciones";
            this.Observations.Name = "Observations";
            this.Observations.ReadOnly = true;
            this.Observations.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Observations.Width = 200;
            // 
            // Year
            // 
            this.Year.DataPropertyName = "year";
            this.Year.HeaderText = "Año";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 60;
            // 
            // MonthName
            // 
            this.MonthName.DataPropertyName = "MonthName";
            this.MonthName.HeaderText = "Mes";
            this.MonthName.Name = "MonthName";
            this.MonthName.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "total";
            this.Total.HeaderText = "Monto";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 80;
            // 
            // Aux
            // 
            this.Aux.DataPropertyName = "aux";
            this.Aux.HeaderText = "Activo";
            this.Aux.Name = "Aux";
            this.Aux.ReadOnly = true;
            this.Aux.Width = 45;
            // 
            // Aux2
            // 
            this.Aux2.DataPropertyName = "aux2";
            this.Aux2.HeaderText = "Alta";
            this.Aux2.Name = "Aux2";
            this.Aux2.ReadOnly = true;
            this.Aux2.Width = 120;
            // 
            // Printbtn
            // 
            this.Printbtn.DataPropertyName = "Printbtn";
            this.Printbtn.HeaderText = "Imprimir";
            this.Printbtn.Name = "Printbtn";
            this.Printbtn.ReadOnly = true;
            this.Printbtn.Width = 70;
            // 
            // btnNew
            // 
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(887, 463);
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
            this.btnDelete.Location = new System.Drawing.Point(968, 463);
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
            this.btnExit.Location = new System.Drawing.Point(1049, 463);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "    Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFind
            // 
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(1166, 58);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 16;
            this.btnFind.Text = "     Buscar";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 110;
            this.label5.Text = "Busqueda:";
            // 
            // txtFind
            // 
            // 
            // 
            // 
            this.txtFind.CustomButton.Image = null;
            this.txtFind.CustomButton.Location = new System.Drawing.Point(1020, 1);
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
            this.txtFind.Location = new System.Drawing.Point(82, 63);
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
            this.txtFind.Size = new System.Drawing.Size(1042, 23);
            this.txtFind.TabIndex = 111;
            this.txtFind.UseSelectable = true;
            this.txtFind.WaterMark = "Introduzca su búsqueda";
            this.txtFind.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFind.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFind.Click += new System.EventHandler(this.txtFind_Click);
            this.txtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyUp_1);
            // 
            // pageList
            // 
            this.pageList.Location = new System.Drawing.Point(21, 463);
            this.pageList.Name = "pageList";
            this.pageList.Size = new System.Drawing.Size(396, 30);
            this.pageList.TabIndex = 112;
            // 
            // HabitantList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 500);
            this.Controls.Add(this.pageList);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.gvList);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Tag = "HabitantList";
            this.Text = "Habitantes";
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
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtFind;
        private Pager pageList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observations;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aux;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aux2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Printbtn;
    }
}