using System;
using Xunit;
using CalcAPI.Services;

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
        [InlineData("20.00", 1, "0.10", "22")]
        [InlineData("20.00", 4, "0.11", "30.36")]
        [InlineData("2030.10", 5, "0.12", "3577.72")]
        public void ShoulCalculateCompoundInterest(String initialValue, int months, String rate, String result)
        {

            decimal compoundInterestReturn = _service.CalculateCompoundInterest(Convert.ToDecimal(initialValue), months, Convert.ToDecimal(rate));
            Assert.Equal(Convert.ToDecimal(result), compoundInterestReturn);
        }
    }
}
