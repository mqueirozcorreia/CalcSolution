using System;
using System.Collections.Generic;

namespace CalcAPI.Models
{
    public class CompoundInterestModels
    {
        public decimal CalculateCompoundInterest(decimal initialValue)
        {
            if(initialValue == 0){
                return 0;
            }

            return 1;
        }
    }
}
