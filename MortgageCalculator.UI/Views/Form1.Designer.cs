namespace MortgageCalculator.UI
{
    partial class Form1
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
            this.calculatorPanel = new System.Windows.Forms.Panel();
            this.totalAmountWithIntrest_txtbox = new System.Windows.Forms.Label();
            this.intrestAmountPaid_label = new System.Windows.Forms.Label();
            this.calculate_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.duration_txtBox = new System.Windows.Forms.TextBox();
            this.intrestRate_label = new System.Windows.Forms.Label();
            this.interestRate_txtBox = new System.Windows.Forms.TextBox();
            this.loanAmount_label = new System.Windows.Forms.Label();
            this.loanAmount_txtBox = new System.Windows.Forms.TextBox();
            this.adminLogin_button = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.dataGrid_panel = new System.Windows.Forms.Panel();
            this.mortgageGrid = new System.Windows.Forms.DataGridView();
            this.mortgageDataDataSet = new MortgageCalculator.UI.MortgageDataDataSet();
            this.login_button = new System.Windows.Forms.Button();
            this.AdminLoginPanel = new System.Windows.Forms.Panel();
            this.submit_button = new System.Windows.Forms.Button();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.username_txtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mortgagetype_combobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calculatorPanel.SuspendLayout();
            this.dataGrid_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mortgageGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mortgageDataDataSet)).BeginInit();
            this.AdminLoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculatorPanel
            // 
            this.calculatorPanel.Controls.Add(this.mortgagetype_combobox);
            this.calculatorPanel.Controls.Add(this.label4);
            this.calculatorPanel.Controls.Add(this.totalAmountWithIntrest_txtbox);
            this.calculatorPanel.Controls.Add(this.intrestAmountPaid_label);
            this.calculatorPanel.Controls.Add(this.calculate_button);
            this.calculatorPanel.Controls.Add(this.label2);
            this.calculatorPanel.Controls.Add(this.duration_txtBox);
            this.calculatorPanel.Controls.Add(this.intrestRate_label);
            this.calculatorPanel.Controls.Add(this.interestRate_txtBox);
            this.calculatorPanel.Controls.Add(this.loanAmount_label);
            this.calculatorPanel.Controls.Add(this.loanAmount_txtBox);
            this.calculatorPanel.Location = new System.Drawing.Point(55, 104);
            this.calculatorPanel.Name = "calculatorPanel";
            this.calculatorPanel.Size = new System.Drawing.Size(512, 502);
            this.calculatorPanel.TabIndex = 9;
            this.calculatorPanel.Visible = false;
            // 
            // totalAmountWithIntrest_txtbox
            // 
            this.totalAmountWithIntrest_txtbox.AutoSize = true;
            this.totalAmountWithIntrest_txtbox.Location = new System.Drawing.Point(167, 384);
            this.totalAmountWithIntrest_txtbox.Name = "totalAmountWithIntrest_txtbox";
            this.totalAmountWithIntrest_txtbox.Size = new System.Drawing.Size(51, 20);
            this.totalAmountWithIntrest_txtbox.TabIndex = 17;
            this.totalAmountWithIntrest_txtbox.Text = "label3";
            this.totalAmountWithIntrest_txtbox.Visible = false;
            // 
            // intrestAmountPaid_label
            // 
            this.intrestAmountPaid_label.AutoSize = true;
            this.intrestAmountPaid_label.Location = new System.Drawing.Point(167, 440);
            this.intrestAmountPaid_label.Name = "intrestAmountPaid_label";
            this.intrestAmountPaid_label.Size = new System.Drawing.Size(51, 20);
            this.intrestAmountPaid_label.TabIndex = 16;
            this.intrestAmountPaid_label.Text = "label1";
            this.intrestAmountPaid_label.Visible = false;
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(160, 267);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(154, 51);
            this.calculate_button.TabIndex = 15;
            this.calculate_button.Text = "Calculate";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Loan Duration (In Years)";
            // 
            // duration_txtBox
            // 
            this.duration_txtBox.Location = new System.Drawing.Point(274, 171);
            this.duration_txtBox.Name = "duration_txtBox";
            this.duration_txtBox.Size = new System.Drawing.Size(194, 26);
            this.duration_txtBox.TabIndex = 13;
            // 
            // intrestRate_label
            // 
            this.intrestRate_label.AutoSize = true;
            this.intrestRate_label.Location = new System.Drawing.Point(44, 102);
            this.intrestRate_label.Name = "intrestRate_label";
            this.intrestRate_label.Size = new System.Drawing.Size(107, 20);
            this.intrestRate_label.TabIndex = 12;
            this.intrestRate_label.Text = " Interest Rate";
            // 
            // interestRate_txtBox
            // 
            this.interestRate_txtBox.Location = new System.Drawing.Point(274, 102);
            this.interestRate_txtBox.Name = "interestRate_txtBox";
            this.interestRate_txtBox.Size = new System.Drawing.Size(194, 26);
            this.interestRate_txtBox.TabIndex = 11;
            // 
            // loanAmount_label
            // 
            this.loanAmount_label.AutoSize = true;
            this.loanAmount_label.Location = new System.Drawing.Point(44, 42);
            this.loanAmount_label.Name = "loanAmount_label";
            this.loanAmount_label.Size = new System.Drawing.Size(105, 20);
            this.loanAmount_label.TabIndex = 10;
            this.loanAmount_label.Text = "Loan Amount";
            // 
            // loanAmount_txtBox
            // 
            this.loanAmount_txtBox.Location = new System.Drawing.Point(274, 42);
            this.loanAmount_txtBox.Name = "loanAmount_txtBox";
            this.loanAmount_txtBox.Size = new System.Drawing.Size(194, 26);
            this.loanAmount_txtBox.TabIndex = 9;
            // 
            // adminLogin_button
            // 
            this.adminLogin_button.Location = new System.Drawing.Point(55, 47);
            this.adminLogin_button.Name = "adminLogin_button";
            this.adminLogin_button.Size = new System.Drawing.Size(200, 51);
            this.adminLogin_button.TabIndex = 18;
            this.adminLogin_button.Text = "Show Active Mortgage";
            this.adminLogin_button.UseVisualStyleBackColor = true;
            this.adminLogin_button.Click += new System.EventHandler(this.adminLogin_button_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(261, 47);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(163, 51);
            this.loginButton.TabIndex = 19;
            this.loginButton.Text = "Montage Calculator";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // dataGrid_panel
            // 
            this.dataGrid_panel.Controls.Add(this.mortgageGrid);
            this.dataGrid_panel.Location = new System.Drawing.Point(55, 116);
            this.dataGrid_panel.Name = "dataGrid_panel";
            this.dataGrid_panel.Size = new System.Drawing.Size(1104, 468);
            this.dataGrid_panel.TabIndex = 20;
            // 
            // mortgageGrid
            // 
            this.mortgageGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mortgageGrid.Location = new System.Drawing.Point(3, 6);
            this.mortgageGrid.Name = "mortgageGrid";
            this.mortgageGrid.RowHeadersWidth = 62;
            this.mortgageGrid.RowTemplate.Height = 28;
            this.mortgageGrid.Size = new System.Drawing.Size(1101, 442);
            this.mortgageGrid.TabIndex = 0;
            this.mortgageGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mortgageGrid_CellClick);
            // 
            // mortgageDataDataSet
            // 
            this.mortgageDataDataSet.DataSetName = "MortgageDataDataSet";
            this.mortgageDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(442, 47);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(163, 51);
            this.login_button.TabIndex = 21;
            this.login_button.Text = "Admin Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // AdminLoginPanel
            // 
            this.AdminLoginPanel.Controls.Add(this.submit_button);
            this.AdminLoginPanel.Controls.Add(this.password_txtbox);
            this.AdminLoginPanel.Controls.Add(this.username_txtBox);
            this.AdminLoginPanel.Controls.Add(this.label3);
            this.AdminLoginPanel.Controls.Add(this.label1);
            this.AdminLoginPanel.Location = new System.Drawing.Point(43, 104);
            this.AdminLoginPanel.Name = "AdminLoginPanel";
            this.AdminLoginPanel.Size = new System.Drawing.Size(521, 438);
            this.AdminLoginPanel.TabIndex = 1;
            this.AdminLoginPanel.Visible = false;
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(157, 245);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(163, 51);
            this.submit_button.TabIndex = 22;
            this.submit_button.Text = "Login";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(265, 163);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.PasswordChar = '*';
            this.password_txtbox.Size = new System.Drawing.Size(156, 26);
            this.password_txtbox.TabIndex = 3;
            // 
            // username_txtBox
            // 
            this.username_txtBox.Location = new System.Drawing.Point(265, 117);
            this.username_txtBox.Name = "username_txtBox";
            this.username_txtBox.Size = new System.Drawing.Size(156, 26);
            this.username_txtBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // mortgagetype_combobox
            // 
            this.mortgagetype_combobox.FormattingEnabled = true;
            this.mortgagetype_combobox.Location = new System.Drawing.Point(274, 219);
            this.mortgagetype_combobox.Name = "mortgagetype_combobox";
            this.mortgagetype_combobox.Size = new System.Drawing.Size(194, 28);
            this.mortgagetype_combobox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mortgage Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 635);
            this.Controls.Add(this.calculatorPanel);
            this.Controls.Add(this.AdminLoginPanel);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.dataGrid_panel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.adminLogin_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.calculatorPanel.ResumeLayout(false);
            this.calculatorPanel.PerformLayout();
            this.dataGrid_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mortgageGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mortgageDataDataSet)).EndInit();
            this.AdminLoginPanel.ResumeLayout(false);
            this.AdminLoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel calculatorPanel;
        private System.Windows.Forms.Label totalAmountWithIntrest_txtbox;
        private System.Windows.Forms.Label intrestAmountPaid_label;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox duration_txtBox;
        private System.Windows.Forms.Label intrestRate_label;
        private System.Windows.Forms.TextBox interestRate_txtBox;
        private System.Windows.Forms.Label loanAmount_label;
        private System.Windows.Forms.TextBox loanAmount_txtBox;
        private System.Windows.Forms.Button adminLogin_button;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel dataGrid_panel;
        private MortgageDataDataSet mortgageDataDataSet;
        private System.Windows.Forms.DataGridView mortgageGrid;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Panel AdminLoginPanel;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.TextBox username_txtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox mortgagetype_combobox;
        private System.Windows.Forms.Label label4;
    }
}

