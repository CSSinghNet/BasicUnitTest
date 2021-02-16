using BasicCalculation;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculationTest
{
   public class EmailValidationTest
    {
        [Fact]
        public void Test_Email_Valid()
        {
            // Arrange
            var emailClass=new EmailValidation();
            var expectedemail = "cs@gmail.com";

            // Act
            var result = emailClass.isEmailAddressValid(expectedemail);

            // Assert
            Assert.True(result);

        }

        [Theory]
        [InlineData("cs@gmail.com",true)]
        [InlineData("cs@@gmail.com",true)]
        [InlineData("cs@gmail.12@.com",false)]
        public void Test_Email_Verify(string mail,bool result)
        {
            // Arrange
            var emailClass = new EmailValidation();

            // Act
            var isvalid = emailClass.isEmailAddressValid(mail);

            // Assert
            Assert.Equal(result,isvalid);

        }

    }
}
