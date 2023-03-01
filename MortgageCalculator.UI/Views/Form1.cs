using MortgageCalculator.Dto;
using MortgageCalculator.Dto.BusinessRules;
using MortgageCalculator.Dto.MortgageData;
using MortgageCalculator.UI.Dto;
using MortgageCalculator.UI.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace MortgageCalculator.UI
{
    public partial class Form1 : Form
    {
        private AddMortgageForm mortgageForm;
        private bool IsMortageAscending = false;
        private bool IsIntrestRepaymentAscending = true;
        public Form1()
        {
            InitializeComponent();
            GetMortgageData();
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            try
            {
                double P = double.Parse(loanAmount_txtBox.Text);
                double i = double.Parse(interestRate_txtBox.Text) / 100;
                int n = int.Parse(duration_txtBox.Text);
                double calculatedIntrest = P * i * n;
                double calculatedTotalAmount = calculatedIntrest + P;
                string intrestWithAmount = "Total Amount including Intrest is " + calculatedTotalAmount.ToString();
                string intrestPaid = "Total intrest paid over lifetime is " + calculatedIntrest.ToString();
                totalAmountWithIntrest_txtbox.Visible = true;
                intrestAmountPaid_label.Visible = true;
                totalAmountWithIntrest_txtbox.Text = intrestWithAmount;
                intrestAmountPaid_label.Text = intrestPaid;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void adminLogin_button_Click(object sender, EventArgs e)
        {
            try
            {
                dataGrid_panel.Visible = true;
                calculatorPanel.Visible = false;
                AdminLoginPanel.Visible = false;
                GetMortgageData();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                calculatorPanel.Visible = true;
                dataGrid_panel.Visible = false;
                AdminLoginPanel.Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public bool GetMortgageData()
        {
            try
            {
                MortgageData data = new MortgageData();
                var result = data.GetAllMortgages();
                List<DtoMortgageBindingData> dataToBind = new List<DtoMortgageBindingData>();
                foreach (var item in result)
                {
                    DtoMortgageBindingData mortgage = new DtoMortgageBindingData()
                    {
                        Name = item.Name,
                        MortgageType = item.MortgageType.ToString(),
                        InterestRepayment = item.InterestRepayment.ToString(),
                        CancellationFee = item.CancellationFee,
                        EstablishmentFee = item.EstablishmentFee,
                        TermsInMonths = item.TermsInMonths
                    };
                    dataToBind.Add(mortgage);
                }
                mortgageGrid.DataSource = dataToBind;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                AdminLoginPanel.Visible = true;
                calculatorPanel.Visible = false;
                dataGrid_panel.Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void AddMortgageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                mortgageForm = null;
                dataGrid_panel.Visible = true;
                calculatorPanel.Visible = false;
                AdminLoginPanel.Visible = false;
                GetMortgageData();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void submit_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (username_txtBox.Text == "admin" && password_txtbox.Text == "admin")
                {
                    if (mortgageForm == null)
                    {
                        mortgageForm = new AddMortgageForm();
                        mortgageForm.Owner = this;
                        mortgageForm.FormClosed += AddMortgageForm_FormClosed;
                        mortgageForm.Show();
                    }
                    else
                    {
                        mortgageForm.Activate();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credientials");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void mortgageGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = mortgageGrid.Columns[e.ColumnIndex].Name;
            if (columnName == "MortgageType")
            {
                if (IsMortageAscending)
                {
                    List<DtoMortgageBindingData> source = (List<DtoMortgageBindingData>)mortgageGrid.DataSource;
                    var sortedItems = from s in source
                                      orderby s.MortgageType descending
                                      select s;
                    mortgageGrid.DataSource = sortedItems.ToList();
                    IsMortageAscending = false;
                }
                else
                {
                    List<DtoMortgageBindingData> source = (List<DtoMortgageBindingData>)mortgageGrid.DataSource;
                    var sortedItems = from s in source
                                      orderby s.MortgageType ascending
                                      select s;
                    mortgageGrid.DataSource = sortedItems.ToList();
                    IsMortageAscending = true;
                }
            }
            if (columnName == "InterestRepayment")
            {
                if (IsIntrestRepaymentAscending)
                {
                    List<DtoMortgageBindingData> source = (List<DtoMortgageBindingData>)mortgageGrid.DataSource;
                    var sortedItems = from s in source
                                      orderby s.InterestRepayment descending
                                      select s;
                    mortgageGrid.DataSource = sortedItems.ToList();
                    IsIntrestRepaymentAscending = false;
                }
                else
                {
                    List<DtoMortgageBindingData> source = (List<DtoMortgageBindingData>)mortgageGrid.DataSource;
                    var sortedItems = from s in source
                                      orderby s.InterestRepayment ascending
                                      select s;
                    mortgageGrid.DataSource = sortedItems.ToList();
                    IsIntrestRepaymentAscending = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                MortgageData dataSource = new MortgageData();
                var MortgageTypes = dataSource.GetallMortgageType();
                mortgagetype_combobox.DataSource = MortgageTypes;
                mortgagetype_combobox.DisplayMember = "MortgageTypeName";
                mortgagetype_combobox.ValueMember = "MortgageTypeId";
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
