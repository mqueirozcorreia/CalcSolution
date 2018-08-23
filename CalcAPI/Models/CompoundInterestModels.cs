using System;
using System.Collections.Generic;

namespace CalcAPI.Models
{
    public class CompoundInterestModels
    {
        public decimal CalculateCompoundInterest(decimal initialValue, int months, decimal rate)
        {
            if (initialValue == 0)
            {
                return 0;
            }

            if (months == 0 || rate == 0)
            {
                return initialValue;
            }

            return 1;
        }
    }
}
