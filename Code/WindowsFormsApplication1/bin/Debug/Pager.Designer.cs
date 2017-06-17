namespace WindowsFormsApplication1
{
    partial class Pager
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pager));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRows = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPageLast = new System.Windows.Forms.Button();
            this.btnPageNext = new System.Windows.Forms.Button();
            this.btnPageFirst = new System.Windows.Forms.Button();
            this.btnPagePrevious = new System.Windows.Forms.Button();
            this.txtPageCurrent = new MetroFramework.Controls.MetroTextBox();
            this.txtPageTotal = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Filas:";
            // 
            // cmbRows
            // 
            this.cmbRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRows.FormattingEnabled = true;
            this.cmbRows.Items.AddRange(new object[] {
            "15",
            "25",
            "50",
            "100",
            "150",
            "200"});
            this.cmbRows.Location = new System.Drawing.Point(341, 5);
            this.cmbRows.Name = "cmbRows";
            this.cmbRows.Size = new System.Drawing.Size(45, 21);
            this.cmbRows.TabIndex = 25;
            this.cmbRows.SelectedIndexChanged += new System.EventHandler(this.cmbRows_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "de";
            // 
            // btnPageLast
            // 
            this.btnPageLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPageLast.Image = ((System.Drawing.Image)(resources.GetObject("btnPageLast.Image")));
            this.btnPageLast.Location = new System.Drawing.Point(269, 5);
            this.btnPageLast.Name = "btnPageLast";
            this.btnPageLast.Size = new System.Drawing.Size(29, 20);
            this.btnPageLast.TabIndex = 20;
            this.btnPageLast.UseVisualStyleBackColor = true;
            this.btnPageLast.Click += new System.EventHandler(this.btnPageLast_Click);
            // 
            // btnPageNext
            // 
            this.btnPageNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPageNext.Image = ((System.Drawing.Image)(resources.GetObject("btnPageNext.Image")));
            this.btnPageNext.Location = new System.Drawing.Point(234, 5);
            this.btnPageNext.Name = "btnPageNext";
            this.btnPageNext.Size = new System.Drawing.Size(29, 20);
            this.btnPageNext.TabIndex = 21;
            this.btnPageNext.UseVisualStyleBackColor = true;
            this.btnPageNext.Click += new System.EventHandler(this.btnPageNext_Click);
            // 
            // btnPageFirst
            // 
            this.btnPageFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPageFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnPageFirst.Image")));
            this.btnPageFirst.Location = new System.Drawing.Point(3, 5);
            this.btnPageFirst.Name = "btnPageFirst";
            this.btnPageFirst.Size = new System.Drawing.Size(29, 20);
            this.btnPageFirst.TabIndex = 19;
            this.btnPageFirst.UseVisualStyleBackColor = true;
            this.btnPageFirst.Click += new System.EventHandler(this.btnPageFirst_Click);
            // 
            // btnPagePrevious
            // 
            this.btnPagePrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagePrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPagePrevious.Image")));
            this.btnPagePrevious.Location = new System.Drawing.Point(38, 5);
            this.btnPagePrevious.Name = "btnPagePrevious";
            this.btnPagePrevious.Size = new System.Drawing.Size(29, 20);
            this.btnPagePrevious.TabIndex = 18;
            this.btnPagePrevious.UseVisualStyleBackColor = true;
            this.btnPagePrevious.Click += new System.EventHandler(this.btnPagePrevious_Click);
            // 
            // txtPageCurrent
            // 
            // 
            // 
            // 
            this.txtPageCurrent.CustomButton.Image = null;
            this.txtPageCurrent.CustomButton.Location = new System.Drawing.Point(40, 1);
            this.txtPageCurrent.CustomButton.Name = "";
            this.txtPageCurrent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPageCurrent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPageCurrent.CustomButton.TabIndex = 1;
            this.txtPageCurrent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPageCurrent.CustomButton.UseSelectable = true;
            this.txtPageCurrent.CustomButton.Visible = false;
            this.txtPageCurrent.DisplayIcon = true;
            this.txtPageCurrent.Icon = ((System.Drawing.Image)(resources.GetObject("txtPageCurrent.Icon")));
            this.txtPageCurrent.Lines = new string[] {
        "1"};
            this.txtPageCurrent.Location = new System.Drawing.Point(73, 2);
            this.txtPageCurrent.MaxLength = 4;
            this.txtPageCurrent.Name = "txtPageCurrent";
            this.txtPageCurrent.PasswordChar = '\0';
            this.txtPageCurrent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPageCurrent.SelectedText = "";
            this.txtPageCurrent.SelectionLength = 0;
            this.txtPageCurrent.SelectionStart = 0;
            this.txtPageCurrent.ShortcutsEnabled = true;
            this.txtPageCurrent.Size = new System.Drawing.Size(62, 23);
            this.txtPageCurrent.TabIndex = 110;
            this.txtPageCurrent.Text = "1";
            this.txtPageCurrent.UseSelectable = true;
            this.txtPageCurrent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPageCurrent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPageCurrent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPageCurrent_KeyPress_1);
            this.txtPageCurrent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPageCurrent_KeyUp_1);
            // 
            // txtPageTotal
            // 
            // 
            // 
            // 
            this.txtPageTotal.CustomButton.Image = null;
            this.txtPageTotal.CustomButton.Location = new System.Drawing.Point(40, 1);
            this.txtPageTotal.CustomButton.Name = "";
            this.txtPageTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPageTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPageTotal.CustomButton.TabIndex = 1;
            this.txtPageTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPageTotal.CustomButton.UseSelectable = true;
            this.txtPageTotal.CustomButton.Visible = false;
            this.txtPageTotal.DisplayIcon = true;
            this.txtPageTotal.Icon = ((System.Drawing.Image)(resources.GetObject("txtPageTotal.Icon")));
            this.txtPageTotal.Lines = new string[] {
        "1"};
            this.txtPageTotal.Location = new System.Drawing.Point(166, 2);
            this.txtPageTotal.MaxLength = 4;
            this.txtPageTotal.Name = "txtPageTotal";
            this.txtPageTotal.PasswordChar = '\0';
            this.txtPageTotal.ReadOnly = true;
            this.txtPageTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPageTotal.SelectedText = "";
            this.txtPageTotal.SelectionLength = 0;
            this.txtPageTotal.SelectionStart = 0;
            this.txtPageTotal.ShortcutsEnabled = true;
            this.txtPageTotal.Size = new System.Drawing.Size(62, 23);
            this.txtPageTotal.TabIndex = 111;
            this.txtPageTotal.Text = "1";
            this.txtPageTotal.UseSelectable = true;
            this.txtPageTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPageTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Pager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPageTotal);
            this.Controls.Add(this.txtPageCurrent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPageLast);
            this.Controls.Add(this.btnPageNext);
            this.Controls.Add(this.btnPageFirst);
            this.Controls.Add(this.btnPagePrevious);
            this.Name = "Pager";
            this.Size = new System.Drawing.Size(395, 30);
            this.Load += new System.EventHandler(this.Pager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPageLast;
        private System.Windows.Forms.Button btnPageNext;
        private System.Windows.Forms.Button btnPageFirst;
        private System.Windows.Forms.Button btnPagePrevious;
        private MetroFramework.Controls.MetroTextBox txtPageCurrent;
        private MetroFramework.Controls.MetroTextBox txtPageTotal;
    }
}
