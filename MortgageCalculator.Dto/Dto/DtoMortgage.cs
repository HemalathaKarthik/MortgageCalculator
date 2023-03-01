using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator.UI.Dto
{
    public class DtoMortgage
    {
        public string Name { get; set; }
        public int MortgageTypeId { get; set; }
        public int InterestRepaymentId { get; set; }
        public string MortgageType { get; set; }
        public string InterestRepayment { get; set; }
        public int TermsInMonths { get; set; }
        public decimal CancellationFee { get; set; }
        public decimal EstablishmentFee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid SchemaIdentifier { get; set; }
    }
    public class DtoMortgageBindingData
    {
        public string Name { get; set; }
        public string MortgageType { get; set; }
        public string InterestRepayment { get; set; }
        public int TermsInMonths { get; set; }
        public decimal CancellationFee { get; set; }
        public decimal EstablishmentFee { get; set; }
    }
}
