using Xunit;
using System.Collections.Generic;
using ConsoleAppSubtraction;

namespace ConsoleAppResta.Tests
{
    public class SubstractionTests
    {
        readonly Subtraction subtraction1 = new Subtraction(12,4);
        readonly Subtraction subtraction2 = new Subtraction(-8, 4);
        readonly Subtraction subtraction3 = new Subtraction(-8,7.3 );
        readonly Subtraction subtraction4 = new Subtraction(-3,-6);
        readonly Subtraction subtraction5 = new Subtraction(79228162514264337593543950335.20, 0);

        [Fact]
        public void Subtract_TwoIntegersNumbers12_4_Return8()
        {
            Assert.Equal(8, subtraction1.Subtract());
        }

        [Fact]
        public void Subtract_TwoIntegerNumbersOneNegative_8_4_ReturnNegative12()
        {
            Assert.Equal(-12, subtraction2.Subtract());
        }

        [Fact]
        public void Subtract_DecimalNumbers_ReturnDecimalNumbers()
        {
            Assert.Equal(-15.3, subtraction3.Subtract());
        }

        [Fact]
        public void Subtract_TwoNegativeNumbers_3_6_ReturnPositiveNumber3()
        {           
            Assert.Equal(3, subtraction4.Subtract());
        }

        [Fact]
        public void Subtract_TwoIntegersNumbers12_4_NotReturn8()
        {
            Assert.NotEqual(-7, subtraction1.Subtract());
        }

        [Fact]
        public void Subtract_TwoIntegerNumbersOneNegative_8_4_NotReturnNegative12()
        {
            Assert.NotEqual(12, subtraction2.Subtract());
        }

        [Fact]
        public void Subtract_DecimalNumbers_NotReturnDecimalNumbers()
        {
            Assert.NotEqual(15.3, subtraction3.Subtract());
        }

        [Fact]
        public void Subtract_TwoNegativeNumbers_3_6_NotReturnPositiveNumber3()
        {
            Assert.NotEqual(-3, subtraction4.Subtract());
        }


    }
}
