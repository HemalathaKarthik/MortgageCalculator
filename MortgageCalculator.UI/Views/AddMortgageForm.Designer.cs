namespace MortgageCalculator.UI.Views
{
    partial class AddMortgageForm
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
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startDate_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.endDate_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.terms_txtbox = new System.Windows.Forms.TextBox();
            this.cancellationFee_txtbox = new System.Windows.Forms.TextBox();
            this.establishmentFee_txtbox = new System.Windows.Forms.TextBox();
            this.mortgagetype_combobox = new System.Windows.Forms.ComboBox();
            this.intrestRepayment_combobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(382, 114);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(161, 26);
            this.name_txtbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mortgage Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "InterestRepayment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "End Date";
            // 
            // startDate_datetimepicker
            // 
            this.startDate_datetimepicker.Location = new System.Drawing.Point(382, 237);
            this.startDate_datetimepicker.Name = "startDate_datetimepicker";
            this.startDate_datetimepicker.Size = new System.Drawing.Size(161, 26);
            this.startDate_datetimepicker.TabIndex = 10;
            // 
            // endDate_datetimepicker
            // 
            this.endDate_datetimepicker.Location = new System.Drawing.Point(382, 280);
            this.endDate_datetimepicker.Name = "endDate_datetimepicker";
            this.endDate_datetimepicker.Size = new System.Drawing.Size(161, 26);
            this.endDate_datetimepicker.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Terms In Months";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cancellation Fee";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Establishment Fee";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // terms_txtbox
            // 
            this.terms_txtbox.Location = new System.Drawing.Point(382, 322);
            this.terms_txtbox.Name = "terms_txtbox";
            this.terms_txtbox.Size = new System.Drawing.Size(161, 26);
            this.terms_txtbox.TabIndex = 19;
            this.terms_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            // 
            // cancellationFee_txtbox
            // 
            this.cancellationFee_txtbox.Location = new System.Drawing.Point(382, 363);
            this.cancellationFee_txtbox.Name = "cancellationFee_txtbox";
            this.cancellationFee_txtbox.Size = new System.Drawing.Size(161, 26);
            this.cancellationFee_txtbox.TabIndex = 20;
            this.cancellationFee_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            // 
            // establishmentFee_txtbox
            // 
            this.establishmentFee_txtbox.Location = new System.Drawing.Point(382, 401);
            this.establishmentFee_txtbox.Name = "establishmentFee_txtbox";
            this.establishmentFee_txtbox.Size = new System.Drawing.Size(161, 26);
            this.establishmentFee_txtbox.TabIndex = 21;
            this.establishmentFee_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            // 
            // mortgagetype_combobox
            // 
            this.mortgagetype_combobox.FormattingEnabled = true;
            this.mortgagetype_combobox.Location = new System.Drawing.Point(382, 153);
            this.mortgagetype_combobox.Name = "mortgagetype_combobox";
            this.mortgagetype_combobox.Size = new System.Drawing.Size(161, 28);
            this.mortgagetype_combobox.TabIndex = 22;
            // 
            // intrestRepayment_combobox
            // 
            this.intrestRepayment_combobox.FormattingEnabled = true;
            this.intrestRepayment_combobox.Location = new System.Drawing.Point(382, 194);
            this.intrestRepayment_combobox.Name = "intrestRepayment_combobox";
            this.intrestRepayment_combobox.Size = new System.Drawing.Size(161, 28);
            this.intrestRepayment_combobox.TabIndex = 23;
            // 
            // AddMortgageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 629);
            this.Controls.Add(this.intrestRepayment_combobox);
            this.Controls.Add(this.mortgagetype_combobox);
            this.Controls.Add(this.establishmentFee_txtbox);
            this.Controls.Add(this.cancellationFee_txtbox);
            this.Controls.Add(this.terms_txtbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.endDate_datetimepicker);
            this.Controls.Add(this.startDate_datetimepicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_txtbox);
            this.Name = "AddMortgageForm";
            this.Text = "AddMortgageForm";
            this.Load += new System.EventHandler(this.AddMortgageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker startDate_datetimepicker;
        private System.Windows.Forms.DateTimePicker endDate_datetimepicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox terms_txtbox;
        private System.Windows.Forms.TextBox cancellationFee_txtbox;
        private System.Windows.Forms.TextBox establishmentFee_txtbox;
        private System.Windows.Forms.ComboBox mortgagetype_combobox;
        private System.Windows.Forms.ComboBox intrestRepayment_combobox;
    }
}