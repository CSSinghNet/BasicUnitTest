using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BasicCalculation;

namespace CalculationTest
{
    public class BasicCalculationTest
    {
        [Fact]
        public void Test_Add()
        {
            // Arrange
            var x = 1.0;
            var y = 2.0;
            var Expect = 3.0;

            // Act
            var sum = BasicCalculation.BasicCalculation.Add(x, y);
            // Assert
            Assert.Equal(Expect, sum);
        }

        [Fact]
        public void Test_Substract()
        {
            // Arrange
            var x = 3.0;
            var y = 2.0;
            var Expect = 1.0;

            // Act
            var Substract = BasicCalculation.BasicCalculation.Substract(x, y);
            // Assert
            Assert.Equal(Expect, Substract);
        }
    }
}
