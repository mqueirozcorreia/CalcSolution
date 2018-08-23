using System;
using Xunit;
using CalcAPI.Models;

namespace CalcAPI.Tests
{
    public class CompoundInterestUnitTest
    {
        private readonly CompoundInterestModels _model;
        public CompoundInterestUnitTest()
        {
            _model = new CompoundInterestModels();
        }

        [Fact]
        public void ShouldReturnZeroWhenInitialValueIsZero()
        {
            decimal initialValue = 0;
            int months = 0;
            decimal rate = 0.01m;
            decimal compoundInterestReturn = _model.CalculateCompoundInterest(initialValue, months, rate);
            Assert.Equal(0, compoundInterestReturn);
        }

        [Fact]
        public void ShouldReturnInitialValueWhenMonthIsZero()
        {
            decimal initialValue = 10;
            int months = 0;
            decimal rate = 0.01m;
            decimal compoundInterestReturn = _model.CalculateCompoundInterest(initialValue, months, rate);
            Assert.Equal(initialValue, compoundInterestReturn);
        }
        
        [Fact]
        public void ShouldReturnInitialValueWhenRateIsZero()
        {
            decimal initialValue = 10;
            int months = 10;
            decimal rate = 0.00m;
            decimal compoundInterestReturn = _model.CalculateCompoundInterest(initialValue, months, rate);
            Assert.Equal(initialValue, compoundInterestReturn);
        }
    }
}
