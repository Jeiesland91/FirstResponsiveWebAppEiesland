using System;
using Xunit;

namespace XUnitTestFirstResponsiveModel
{
    public class UnitTest1
    {
        [Fact]
        public void TestYearOfBirthLessThan1900()
        {
            // ARRANGE
            FirstResponsiveWebAppEiesland.Models.FirstResponsiveModel fr = new FirstResponsiveWebAppEiesland.Models.FirstResponsiveModel();
            fr.YearOfBirth = 1700;
            int expected = 0;

            // ACT
            int actual = fr.AgeThisYear();

            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestValidYearOfBirth()
        {
            // ARRANGE
            FirstResponsiveWebAppEiesland.Models.FirstResponsiveModel fr = new FirstResponsiveWebAppEiesland.Models.FirstResponsiveModel();
            fr.YearOfBirth = 1991;
            int expected = 30;

            // ACT
            int actual = fr.AgeThisYear();

            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestYearOfBirthGreaterThan2021()
        {
            // ARRANGE
            FirstResponsiveWebAppEiesland.Models.FirstResponsiveModel fr = new FirstResponsiveWebAppEiesland.Models.FirstResponsiveModel();
            fr.YearOfBirth = 2030;
            int expected = 0;

            // ACT
            int actual = fr.AgeThisYear();

            // ASSERT
            Assert.Equal(expected, actual);
        }
    }
}
