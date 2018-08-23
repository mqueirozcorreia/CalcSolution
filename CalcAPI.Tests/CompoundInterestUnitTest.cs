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
            decimal compoundInterestReturn = _model.CalculateCompoundInterest(initialValue);
            Assert.Equal(0, compoundInterestReturn);
        }
    }
}
