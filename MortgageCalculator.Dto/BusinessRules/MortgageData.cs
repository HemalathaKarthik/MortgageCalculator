using MortgageCalculator.UI.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MortgageCalculator.Dto.BusinessRules
{
    public interface IMortgageData
    {
        List<Mortgage> GetAllMortgages();
        List<Dto.MortgageData.MortgageType> GetallMortgageType();
        List<Dto.MortgageData.InterestRepayment> GetAllInterestRepayment();
    }

    public class MortgageData : IMortgageData
    {
        public List<Mortgage> GetAllMortgages()
        {
            try
            {
                using (var context = new Dto.MortgageData.MortgageDataContext())
                {
                    var mortgages = context.Mortgages.ToList();
                    List<Mortgage> result = new List<Mortgage>();
                    foreach (var mortgage in mortgages)
                    {
                        result.Add(new Mortgage()
                        {
                            Name = mortgage.Name,
                            EffectiveStartDate = mortgage.EffectiveStartDate,
                            EffectiveEndDate = mortgage.EffectiveEndDate,
                            CancellationFee = mortgage.CancellationFee,
                            EstablishmentFee = mortgage.CancellationFee,
                            InterestRepayment = (InterestRepayment)Enum.Parse(typeof(InterestRepayment), mortgage.InterestRepayment.InterestRepaymentName.ToString()),
                            MortgageId = mortgage.MortgageId,
                            MortgageType = (MortgageType)Enum.Parse(typeof(MortgageType), mortgage.MortgageType.MortgageTypeName.ToString()),
                            TermsInMonths = mortgage.TermsInMonths
                        }
                        );
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public List<Dto.MortgageData.MortgageType> GetallMortgageType()
        {
            try
            {
                using (var context = new Dto.MortgageData.MortgageDataContext())
                {
                    var mortgageTypes = context.MortgageTypes.ToList();
                    return mortgageTypes;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public List<Dto.MortgageData.InterestRepayment> GetAllInterestRepayment()
        {
            try
            {
                using (var context = new Dto.MortgageData.MortgageDataContext())
                {
                    var interestRepayment = context.InterestRepayments.ToList();
                    return interestRepayment;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public bool SaveMortgageData(DtoMortgage dtoMortgage)
        {
            try
            {
                using (var context = new Dto.MortgageData.MortgageDataContext())
                {
                    Dto.MortgageData.Mortgage mortgage = new Dto.MortgageData.Mortgage()
                    {
                        Name = dtoMortgage.Name,
                        CancellationFee = dtoMortgage.CancellationFee,
                        EffectiveEndDate = dtoMortgage.EndDate,
                        EffectiveStartDate = dtoMortgage.StartDate,
                        EstablishmentFee = dtoMortgage.EstablishmentFee,
                        InterestRepaymentId = dtoMortgage.InterestRepaymentId,
                        MortgageTypeId = dtoMortgage.MortgageTypeId,
                        TermsInMonths = dtoMortgage.TermsInMonths,
                        SchemaIdentifier = dtoMortgage.SchemaIdentifier,
                    };
                    context.Mortgages.Add(mortgage);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
