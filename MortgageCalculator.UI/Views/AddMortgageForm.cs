using MortgageCalculator.Dto.BusinessRules;
using MortgageCalculator.Dto.MortgageData;
using MortgageCalculator.UI.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MortgageCalculator.UI.Views
{
    public partial class AddMortgageForm : Form
    {
        private List<MortgageType> MortgageTypes;
        private List<InterestRepayment> interestRepayments;
        public AddMortgageForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DtoMortgage dtoMortgage = new DtoMortgage()
                {
                    Name = name_txtbox.Text,
                    TermsInMonths = int.Parse(terms_txtbox.Text),
                    CancellationFee = int.Parse(cancellationFee_txtbox.Text),
                    EstablishmentFee = int.Parse(establishmentFee_txtbox.Text),
                    InterestRepaymentId = (int)intrestRepayment_combobox.SelectedValue,
                    MortgageTypeId = (int)mortgagetype_combobox.SelectedValue,
                    StartDate = startDate_datetimepicker.Value,
                    EndDate = endDate_datetimepicker.Value,
                    SchemaIdentifier = Guid.NewGuid()
                };
                MortgageData mortgageData = new MortgageData();
                bool result = mortgageData.SaveMortgageData(dtoMortgage);
                if (result)
                {
                    name_txtbox.ResetText();
                    terms_txtbox.ResetText();
                    cancellationFee_txtbox.ResetText();
                    establishmentFee_txtbox.ResetText();
                    startDate_datetimepicker.ResetText();
                    endDate_datetimepicker.ResetText();
                    intrestRepayment_combobox.ResetText();
                    mortgagetype_combobox.ResetText();
                    MessageBox.Show("Saved Successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void AddMortgageForm_Load(object sender, EventArgs e)
        {
            try
            {
                MortgageData dataSource = new MortgageData();
                MortgageTypes = dataSource.GetallMortgageType();
                mortgagetype_combobox.DataSource = MortgageTypes;
                mortgagetype_combobox.DisplayMember = "MortgageTypeName";
                mortgagetype_combobox.ValueMember = "MortgageTypeId";
                interestRepayments = dataSource.GetAllInterestRepayment();
                intrestRepayment_combobox.DataSource = interestRepayments;
                intrestRepayment_combobox.DisplayMember = "InterestRepaymentName";
                intrestRepayment_combobox.ValueMember = "InterestRepaymentId";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void NumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
