using System;
using System.Collections.Generic;

namespace CalcAPI.Models
{
    public class CompoundInterestModels
    {
        public decimal CalculateCompoundInterest(decimal initialValue, int months)
        {
            if (initialValue == 0)
            {
                return 0;
            }

            if (months == 0)
            {
                return initialValue;
            }

            return 1;
        }
    }
}
