using System;
using System.Collections.Generic;

namespace CalcAPI.Models
{
    public class CompoundInterestModels
    {
        public decimal CalculateCompoundInterest(decimal initialValue, int months, decimal rate)
        {
            double resultCalc = (double)initialValue * Math.Pow((1 + (double)rate), months);

            return (decimal)Math.Truncate(100 * resultCalc) / 100;
        }
    }
}
