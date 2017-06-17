namespace WindowsFormsApplication1
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbWaterIntake = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbHabitant = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbval_cmbHabitant = new System.Windows.Forms.PictureBox();
            this.pbval_cmbWaterIntake = new System.Windows.Forms.PictureBox();
            this.pbVal_cmbYear = new System.Windows.Forms.PictureBox();
            this.pbVal_cmbMonth = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbVal_cmbMonthEnd = new System.Windows.Forms.PictureBox();
            this.pbVal_cmbYearEnd = new System.Windows.Forms.PictureBox();
            this.cmbMonthEnd = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbYearEnd = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtAP = new MetroFramework.Controls.MetroTextBox();
            this.txtObservations = new MetroFramework.Controls.MetroTextBox();
            this.txtAmount = new MetroFramework.Controls.MetroTextBox();
            this.txtTotal = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_cmbHabitant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_cmbWaterIntake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbMonthEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbYearEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Total:";
            // 
            // cmbMonth
            // 
            this.cmbMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(88, 170);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(360, 21);
            this.cmbMonth.TabIndex = 5;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mes Inicial:";
            // 
            // cmbYear
            // 
            this.cmbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(88, 143);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(359, 21);
            this.cmbYear.TabIndex = 4;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Año Inicial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Toma de agua:";
            // 
            // cmbWaterIntake
            // 
            this.cmbWaterIntake.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbWaterIntake.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWaterIntake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWaterIntake.FormattingEnabled = true;
            this.cmbWaterIntake.Location = new System.Drawing.Point(88, 116);
            this.cmbWaterIntake.Name = "cmbWaterIntake";
            this.cmbWaterIntake.Size = new System.Drawing.Size(359, 21);
            this.cmbWaterIntake.TabIndex = 3;
            this.cmbWaterIntake.SelectedIndexChanged += new System.EventHandler(this.cmbWaterIntake_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mensualidad:";
            // 
            // btnAccept
            // 
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(257, 402);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(91, 23);
            this.btnAccept.TabIndex = 11;
            this.btnAccept.Text = "    Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(354, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "    Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbHabitant
            // 
            this.cmbHabitant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbHabitant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHabitant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHabitant.FormattingEnabled = true;
            this.cmbHabitant.Location = new System.Drawing.Point(88, 89);
            this.cmbHabitant.Name = "cmbHabitant";
            this.cmbHabitant.Size = new System.Drawing.Size(359, 21);
            this.cmbHabitant.TabIndex = 2;
            this.cmbHabitant.SelectedIndexChanged += new System.EventHandler(this.cmbHabitant_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Habitante:";
            // 
            // pbval_cmbHabitant
            // 
            this.pbval_cmbHabitant.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_cmbHabitant.Image = ((System.Drawing.Image)(resources.GetObject("pbval_cmbHabitant.Image")));
            this.pbval_cmbHabitant.InitialImage = null;
            this.pbval_cmbHabitant.Location = new System.Drawing.Point(454, 92);
            this.pbval_cmbHabitant.Name = "pbval_cmbHabitant";
            this.pbval_cmbHabitant.Size = new System.Drawing.Size(18, 17);
            this.pbval_cmbHabitant.TabIndex = 35;
            this.pbval_cmbHabitant.TabStop = false;
            this.pbval_cmbHabitant.Tag = "Indique el habitante";
            this.pbval_cmbHabitant.Visible = false;
            // 
            // pbval_cmbWaterIntake
            // 
            this.pbval_cmbWaterIntake.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_cmbWaterIntake.Image = ((System.Drawing.Image)(resources.GetObject("pbval_cmbWaterIntake.Image")));
            this.pbval_cmbWaterIntake.InitialImage = null;
            this.pbval_cmbWaterIntake.Location = new System.Drawing.Point(453, 119);
            this.pbval_cmbWaterIntake.Name = "pbval_cmbWaterIntake";
            this.pbval_cmbWaterIntake.Size = new System.Drawing.Size(18, 17);
            this.pbval_cmbWaterIntake.TabIndex = 36;
            this.pbval_cmbWaterIntake.TabStop = false;
            this.pbval_cmbWaterIntake.Tag = "Indique la toma de agua";
            this.pbval_cmbWaterIntake.Visible = false;
            // 
            // pbVal_cmbYear
            // 
            this.pbVal_cmbYear.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbVal_cmbYear.Image = ((System.Drawing.Image)(resources.GetObject("pbVal_cmbYear.Image")));
            this.pbVal_cmbYear.InitialImage = null;
            this.pbVal_cmbYear.Location = new System.Drawing.Point(453, 146);
            this.pbVal_cmbYear.Name = "pbVal_cmbYear";
            this.pbVal_cmbYear.Size = new System.Drawing.Size(18, 17);
            this.pbVal_cmbYear.TabIndex = 106;
            this.pbVal_cmbYear.TabStop = false;
            this.pbVal_cmbYear.Tag = "Indique el año inicial";
            this.pbVal_cmbYear.Visible = false;
            // 
            // pbVal_cmbMonth
            // 
            this.pbVal_cmbMonth.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbVal_cmbMonth.Image = ((System.Drawing.Image)(resources.GetObject("pbVal_cmbMonth.Image")));
            this.pbVal_cmbMonth.InitialImage = null;
            this.pbVal_cmbMonth.Location = new System.Drawing.Point(453, 173);
            this.pbVal_cmbMonth.Name = "pbVal_cmbMonth";
            this.pbVal_cmbMonth.Size = new System.Drawing.Size(18, 17);
            this.pbVal_cmbMonth.TabIndex = 107;
            this.pbVal_cmbMonth.TabStop = false;
            this.pbVal_cmbMonth.Tag = "Indique el mes inicial";
            this.pbVal_cmbMonth.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 109;
            this.label7.Text = "Observaciones:";
            // 
            // pbVal_cmbMonthEnd
            // 
            this.pbVal_cmbMonthEnd.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbVal_cmbMonthEnd.Image = ((System.Drawing.Image)(resources.GetObject("pbVal_cmbMonthEnd.Image")));
            this.pbVal_cmbMonthEnd.InitialImage = null;
            this.pbVal_cmbMonthEnd.Location = new System.Drawing.Point(454, 227);
            this.pbVal_cmbMonthEnd.Name = "pbVal_cmbMonthEnd";
            this.pbVal_cmbMonthEnd.Size = new System.Drawing.Size(18, 17);
            this.pbVal_cmbMonthEnd.TabIndex = 115;
            this.pbVal_cmbMonthEnd.TabStop = false;
            this.pbVal_cmbMonthEnd.Tag = "Indique el mes final";
            this.pbVal_cmbMonthEnd.Visible = false;
            // 
            // pbVal_cmbYearEnd
            // 
            this.pbVal_cmbYearEnd.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbVal_cmbYearEnd.Image = ((System.Drawing.Image)(resources.GetObject("pbVal_cmbYearEnd.Image")));
            this.pbVal_cmbYearEnd.InitialImage = null;
            this.pbVal_cmbYearEnd.Location = new System.Drawing.Point(454, 200);
            this.pbVal_cmbYearEnd.Name = "pbVal_cmbYearEnd";
            this.pbVal_cmbYearEnd.Size = new System.Drawing.Size(18, 17);
            this.pbVal_cmbYearEnd.TabIndex = 114;
            this.pbVal_cmbYearEnd.TabStop = false;
            this.pbVal_cmbYearEnd.Tag = "Indique el año final";
            this.pbVal_cmbYearEnd.Visible = false;
            // 
            // cmbMonthEnd
            // 
            this.cmbMonthEnd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMonthEnd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMonthEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonthEnd.FormattingEnabled = true;
            this.cmbMonthEnd.Location = new System.Drawing.Point(89, 224);
            this.cmbMonthEnd.Name = "cmbMonthEnd";
            this.cmbMonthEnd.Size = new System.Drawing.Size(360, 21);
            this.cmbMonthEnd.TabIndex = 7;
            this.cmbMonthEnd.SelectedIndexChanged += new System.EventHandler(this.cmbMonthEnd_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 112;
            this.label8.Text = "Mes Final:";
            // 
            // cmbYearEnd
            // 
            this.cmbYearEnd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbYearEnd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbYearEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYearEnd.FormattingEnabled = true;
            this.cmbYearEnd.Location = new System.Drawing.Point(89, 197);
            this.cmbYearEnd.Name = "cmbYearEnd";
            this.cmbYearEnd.Size = new System.Drawing.Size(359, 21);
            this.cmbYearEnd.TabIndex = 6;
            this.cmbYearEnd.SelectedIndexChanged += new System.EventHandler(this.cmbYearEnd_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 110;
            this.label9.Text = "Año Final:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 116;
            this.label10.Text = "AP:";
            // 
            // btnFind
            // 
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(358, 60);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(91, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "    Buscar";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtAP
            // 
            // 
            // 
            // 
            this.txtAP.CustomButton.Image = null;
            this.txtAP.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txtAP.CustomButton.Name = "";
            this.txtAP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAP.CustomButton.TabIndex = 1;
            this.txtAP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAP.CustomButton.UseSelectable = true;
            this.txtAP.CustomButton.Visible = false;
            this.txtAP.DisplayIcon = true;
            this.txtAP.Icon = ((System.Drawing.Image)(resources.GetObject("txtAP.Icon")));
            this.txtAP.Lines = new string[0];
            this.txtAP.Location = new System.Drawing.Point(88, 60);
            this.txtAP.MaxLength = 32767;
            this.txtAP.Name = "txtAP";
            this.txtAP.PasswordChar = '\0';
            this.txtAP.PromptText = "Introduzca el AP del habitante";
            this.txtAP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAP.SelectedText = "";
            this.txtAP.SelectionLength = 0;
            this.txtAP.SelectionStart = 0;
            this.txtAP.ShortcutsEnabled = true;
            this.txtAP.ShowClearButton = true;
            this.txtAP.Size = new System.Drawing.Size(264, 23);
            this.txtAP.TabIndex = 0;
            this.txtAP.UseSelectable = true;
            this.txtAP.WaterMark = "Introduzca el AP del habitante";
            this.txtAP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtObservations
            // 
            // 
            // 
            // 
            this.txtObservations.CustomButton.Image = null;
            this.txtObservations.CustomButton.Location = new System.Drawing.Point(244, 2);
            this.txtObservations.CustomButton.Name = "";
            this.txtObservations.CustomButton.Size = new System.Drawing.Size(111, 111);
            this.txtObservations.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtObservations.CustomButton.TabIndex = 1;
            this.txtObservations.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtObservations.CustomButton.UseSelectable = true;
            this.txtObservations.CustomButton.Visible = false;
            this.txtObservations.DisplayIcon = true;
            this.txtObservations.Icon = ((System.Drawing.Image)(resources.GetObject("txtObservations.Icon")));
            this.txtObservations.Lines = new string[0];
            this.txtObservations.Location = new System.Drawing.Point(89, 251);
            this.txtObservations.MaxLength = 32767;
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.PasswordChar = '\0';
            this.txtObservations.PromptText = "Introduzca las observaciones del habitante";
            this.txtObservations.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservations.SelectedText = "";
            this.txtObservations.SelectionLength = 0;
            this.txtObservations.SelectionStart = 0;
            this.txtObservations.ShortcutsEnabled = true;
            this.txtObservations.ShowClearButton = true;
            this.txtObservations.Size = new System.Drawing.Size(358, 116);
            this.txtObservations.TabIndex = 8;
            this.txtObservations.UseSelectable = true;
            this.txtObservations.WaterMark = "Introduzca las observaciones del habitante";
            this.txtObservations.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObservations.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.CustomButton.Image = null;
            this.txtAmount.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.txtAmount.CustomButton.Name = "";
            this.txtAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmount.CustomButton.TabIndex = 1;
            this.txtAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmount.CustomButton.UseSelectable = true;
            this.txtAmount.CustomButton.Visible = false;
            this.txtAmount.DisplayIcon = true;
            this.txtAmount.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtAmount.Icon = ((System.Drawing.Image)(resources.GetObject("txtAmount.Icon")));
            this.txtAmount.Lines = new string[0];
            this.txtAmount.Location = new System.Drawing.Point(89, 373);
            this.txtAmount.MaxLength = 32767;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PromptText = "0.00";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.ShortcutsEnabled = true;
            this.txtAmount.ShowClearButton = true;
            this.txtAmount.Size = new System.Drawing.Size(91, 23);
            this.txtAmount.TabIndex = 9;
            this.txtAmount.TabStop = false;
            this.txtAmount.UseSelectable = true;
            this.txtAmount.WaterMark = "0.00";
            this.txtAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTotal
            // 
            // 
            // 
            // 
            this.txtTotal.CustomButton.Image = null;
            this.txtTotal.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.txtTotal.CustomButton.Name = "";
            this.txtTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotal.CustomButton.TabIndex = 1;
            this.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotal.CustomButton.UseSelectable = true;
            this.txtTotal.CustomButton.Visible = false;
            this.txtTotal.DisplayIcon = true;
            this.txtTotal.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtTotal.Icon = ((System.Drawing.Image)(resources.GetObject("txtTotal.Icon")));
            this.txtTotal.Lines = new string[] {
        "0.00"};
            this.txtTotal.Location = new System.Drawing.Point(354, 373);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PromptText = "0.00";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.ShowClearButton = true;
            this.txtTotal.Size = new System.Drawing.Size(91, 23);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.TabStop = false;
            this.txtTotal.Text = "0.00";
            this.txtTotal.UseSelectable = true;
            this.txtTotal.WaterMark = "0.00";
            this.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 436);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtObservations);
            this.Controls.Add(this.txtAP);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pbVal_cmbMonthEnd);
            this.Controls.Add(this.pbVal_cmbYearEnd);
            this.Controls.Add(this.cmbMonthEnd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbYearEnd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbVal_cmbMonth);
            this.Controls.Add(this.pbVal_cmbYear);
            this.Controls.Add(this.pbval_cmbWaterIntake);
            this.Controls.Add(this.pbval_cmbHabitant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbHabitant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbWaterIntake);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Payment";
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbval_cmbHabitant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_cmbWaterIntake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbMonthEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbYearEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbWaterIntake;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbHabitant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbval_cmbHabitant;
        private System.Windows.Forms.PictureBox pbval_cmbWaterIntake;
        private System.Windows.Forms.PictureBox pbVal_cmbYear;
        private System.Windows.Forms.PictureBox pbVal_cmbMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbVal_cmbMonthEnd;
        private System.Windows.Forms.PictureBox pbVal_cmbYearEnd;
        private System.Windows.Forms.ComboBox cmbMonthEnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbYearEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFind;
        private MetroFramework.Controls.MetroTextBox txtAP;
        private MetroFramework.Controls.MetroTextBox txtObservations;
        private MetroFramework.Controls.MetroTextBox txtAmount;
        private MetroFramework.Controls.MetroTextBox txtTotal;
    }
}