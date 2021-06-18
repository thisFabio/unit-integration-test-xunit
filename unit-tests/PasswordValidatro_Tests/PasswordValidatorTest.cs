using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PasswordValidatorLibrary;



namespace PasswordValidatro_Tests
{
    public class PasswordValidatorTest
    {
        [Fact]
        public void PasswordValidateShouldBeTrue()
        {
            //Arrange
            PasswordValidator password = new PasswordValidator();

            bool expected = true;

            // Act
            bool actual = password.IsValid("P0veryV01!");

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(true, "P@ram4T32")]
        [InlineData(false, "Pallino")]

        public void ValidPassword(bool expected, string password)
        {
            //Arrange
            PasswordValidator passwordValidation = new PasswordValidator();

            

            // Act
            bool actual = passwordValidation.IsValid(password);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
