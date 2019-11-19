using Microsoft.VisualStudio.TestTools.UnitTesting;

using BMICalculator;
using System.Diagnostics.CodeAnalysis;

namespace BMIUnitTestProject
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class BMICalculatorTest
    {
        [TestMethod]
        public void TestBMICategory_ReturnUnderweight()
        {
            //Arrange
            BMI bmi = new BMI
            {
                WeightStones = 5,
                WeightPounds = 4,
                HeightFeet = 5,
                HeightInches = 4
            };

            string expectedResult = "Underweight";

            //Act
            string actualResult = bmi.BMICategory.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestBMICategory_ReturnNormal()
        {
            //Arrange
            BMI bmi = new BMI
            {
                WeightStones = 7,
                WeightPounds = 0,
                HeightFeet = 5,
                HeightInches = 0
            };

            string expectedResult = "Normal";

            //Act
            string actualResult = bmi.BMICategory.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestBMICategory_ReturnOverweight()
        {
            //Arrange
            BMI bmi = new BMI
            {
                WeightStones = 10,
                WeightPounds = 0,
                HeightFeet = 5,
                HeightInches = 0
            };

            string expectedResult = "Overweight";

            //Act
            string actualResult = bmi.BMICategory.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestBMICategory_ReturnObese()
        {
            //Arrange
            BMI bmi = new BMI
            {
                WeightStones = 15,
                WeightPounds = 0,
                HeightFeet = 5,
                HeightInches = 0
            };

            string expectedResult = "Obese";

            //Act
            string actualResult = bmi.BMICategory.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
