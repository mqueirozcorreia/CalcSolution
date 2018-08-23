using System;
using System.Collections.Generic;

namespace CalcAPI.Services
{
    public class CompoundInterestServices
    {
        public decimal CalculateCompoundInterest(decimal initialValue, int months, decimal rate)
        {
            double resultCalc = (double)initialValue * Math.Pow((1 + (double)rate), months);

            return (decimal)Math.Truncate(100 * resultCalc) / 100;
        }
    }
}
