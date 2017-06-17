namespace WindowsFormsApplication1
{
    partial class HabitantFaena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HabitantFaena));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFaena = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHabitant = new System.Windows.Forms.ComboBox();
            this.pbVal_cmbFaena = new System.Windows.Forms.PictureBox();
            this.pbVal_cmbHabitant = new System.Windows.Forms.PictureBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbFaena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbHabitant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 104;
            this.label1.Text = "Cooperacion:";
            // 
            // cmbFaena
            // 
            this.cmbFaena.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFaena.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFaena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaena.FormattingEnabled = true;
            this.cmbFaena.Location = new System.Drawing.Point(78, 91);
            this.cmbFaena.Name = "cmbFaena";
            this.cmbFaena.Size = new System.Drawing.Size(359, 21);
            this.cmbFaena.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 102;
            this.label5.Text = "Habitante:";
            // 
            // cmbHabitant
            // 
            this.cmbHabitant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbHabitant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHabitant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHabitant.FormattingEnabled = true;
            this.cmbHabitant.Location = new System.Drawing.Point(78, 63);
            this.cmbHabitant.Name = "cmbHabitant";
            this.cmbHabitant.Size = new System.Drawing.Size(359, 21);
            this.cmbHabitant.TabIndex = 0;
            this.cmbHabitant.SelectedIndexChanged += new System.EventHandler(this.cmbHabitant_SelectedIndexChanged);
            // 
            // pbVal_cmbFaena
            // 
            this.pbVal_cmbFaena.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbVal_cmbFaena.Image = ((System.Drawing.Image)(resources.GetObject("pbVal_cmbFaena.Image")));
            this.pbVal_cmbFaena.InitialImage = null;
            this.pbVal_cmbFaena.Location = new System.Drawing.Point(443, 91);
            this.pbVal_cmbFaena.Name = "pbVal_cmbFaena";
            this.pbVal_cmbFaena.Size = new System.Drawing.Size(18, 17);
            this.pbVal_cmbFaena.TabIndex = 100;
            this.pbVal_cmbFaena.TabStop = false;
            this.pbVal_cmbFaena.Tag = "Indique el mes inicial";
            this.pbVal_cmbFaena.Visible = false;
            // 
            // pbVal_cmbHabitant
            // 
            this.pbVal_cmbHabitant.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbVal_cmbHabitant.Image = ((System.Drawing.Image)(resources.GetObject("pbVal_cmbHabitant.Image")));
            this.pbVal_cmbHabitant.InitialImage = null;
            this.pbVal_cmbHabitant.Location = new System.Drawing.Point(443, 63);
            this.pbVal_cmbHabitant.Name = "pbVal_cmbHabitant";
            this.pbVal_cmbHabitant.Size = new System.Drawing.Size(18, 17);
            this.pbVal_cmbHabitant.TabIndex = 99;
            this.pbVal_cmbHabitant.TabStop = false;
            this.pbVal_cmbHabitant.Tag = "Indique el año inicial";
            this.pbVal_cmbHabitant.Visible = false;
            // 
            // btnAccept
            // 
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(281, 118);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "    Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(362, 118);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "    Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // HabitantFaena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 153);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFaena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbHabitant);
            this.Controls.Add(this.pbVal_cmbFaena);
            this.Controls.Add(this.pbVal_cmbHabitant);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HabitantFaena";
            this.Text = "Cooperación";
            this.Load += new System.EventHandler(this.Habitant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbFaena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbHabitant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbVal_cmbHabitant;
        private System.Windows.Forms.PictureBox pbVal_cmbFaena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHabitant;
        private System.Windows.Forms.ComboBox cmbFaena;
        private System.Windows.Forms.Label label1;
    }
}