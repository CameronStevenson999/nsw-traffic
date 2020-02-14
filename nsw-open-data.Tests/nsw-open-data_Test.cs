using System;
using Xunit;

namespace nsw_open_data.Tests
{
    public class NameVerifyService_IsValidShould
    {
        private readonly NameVerifyService _nameVerifyService;

        public NameVerifyService_IsValidShould()
        {
            _nameVerifyService = new NameVerifyService();
        }

        #region Sample_TestCode
        [Theory]
        [InlineData("1")]
        [InlineData("2")]
        [InlineData("3")]
        [InlineData("5")]
        [InlineData("77")]
        [InlineData("23")]
        [InlineData("43")]
        public void IsValidName_Int_ReturnFalse(string value)
        {
            var result = _nameVerifyService.IsValidName(value);

            Assert.False(result, $"{value} should not be valid");
        }

        [Theory]
        [InlineData("Dave")]
        [InlineData("Karl")]
        [InlineData("Cameron")]
        public void IsValidName_NotInt_ReturnTrue(string value)
        {
            var result = _nameVerifyService.IsValidName(value);

            Assert.True(result, $"{value} should not be an integer");
        }
        #endregion
    }
}
