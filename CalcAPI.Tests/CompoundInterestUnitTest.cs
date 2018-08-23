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
            int month = 0;
            decimal compoundInterestReturn = _model.CalculateCompoundInterest(initialValue, month);
            Assert.Equal(0, compoundInterestReturn);
        }

        [Fact]
        public void ShouldReturnInitialValueWhenMonthIsZero()
        {
            decimal initialValue = 10;
            int month = 0;
            decimal compoundInterestReturn = _model.CalculateCompoundInterest(initialValue, month);
            Assert.Equal(initialValue, compoundInterestReturn);
        }
    }
}
