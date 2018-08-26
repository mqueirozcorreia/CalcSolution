using System;
using Xunit;
using CalcAPI.Services;
using System.Collections.Generic;

namespace CalcAPI.Tests
{
    public class CompoundInterestUnitTest
    {
        private readonly CompoundInterestServices _service;
        public CompoundInterestUnitTest()
        {
            _service = new CompoundInterestServices();
        }

        [Fact]
        public void ShouldReturnZeroWhenInitialValueIsZero()
        {
            decimal initialValue = 0;
            int months = 0;
            decimal rate = 0.01m;
            decimal compoundInterestReturn = _service.CalculateCompoundInterest(initialValue, months, rate);
            Assert.Equal(0, compoundInterestReturn);
        }

        [Fact]
        public void ShouldReturnInitialValueWhenMonthIsZero()
        {
            decimal initialValue = 10;
            int months = 0;
            decimal rate = 0.01m;
            decimal compoundInterestReturn = _service.CalculateCompoundInterest(initialValue, months, rate);
            Assert.Equal(initialValue, compoundInterestReturn);
        }

        [Fact]
        public void ShouldReturnInitialValueWhenRateIsZero()
        {
            decimal initialValue = 10;
            int months = 10;
            decimal rate = 0.00m;
            decimal compoundInterestReturn = _service.CalculateCompoundInterest(initialValue, months, rate);
            Assert.Equal(initialValue, compoundInterestReturn);
        }

        [Theory]
        [MemberData(nameof(ShoulCalculateCompoundInterestData))]
        public void ShoulCalculateCompoundInterest(decimal initialValue, int months, decimal rate, decimal result)
        {

            decimal compoundInterestReturn = _service.CalculateCompoundInterest(Convert.ToDecimal(initialValue), months, Convert.ToDecimal(rate));
            Assert.Equal(Convert.ToDecimal(result), compoundInterestReturn);
        }
        
        public static IEnumerable<object[]> ShoulCalculateCompoundInterestData =>
        new List<object[]>
        {
            new object[] { 20.00, 1, 0.10, 22},
            new object[] {20.00, 4, 0.11, 30.36},
            new object[] {2030.10, 5, 0.12, 3577.72 },
        };
    }
}
