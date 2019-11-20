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

        [TestMethod]
        public void TestBMIRecommendation_Return_MessageForUnderweight()
        {
            //Arrange
            BMI bmi = new BMI
            {
                WeightStones = 5,
                WeightPounds = 4,
                HeightFeet = 5,
                HeightInches = 4
            };

            string expectedResult = "Follow a healthy diet that incorporates nutritious calorie-dense foods to gain some weight.";

            //Act
            string actualResult = bmi.Recommendation.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestBMIRecommendation_Return_MessageForNormalweight()
        {
            //Arrange
            BMI bmi = new BMI
            {
                WeightStones = 7,
                WeightPounds = 0,
                HeightFeet = 5,
                HeightInches = 0
            };

            string expectedResult = "Stay the way you are. You are in the healthy weight range!";

            //Act
            string actualResult = bmi.Recommendation.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestBMIRecommendation_Return_MessageForOverweight()
        {
            //Arrange
            BMI bmi = new BMI
            {
                WeightStones = 10,
                WeightPounds = 0,
                HeightFeet = 5,
                HeightInches = 0
            };

            string expectedResult = "Engage in moderate physical activity, progressing to 30 minutes or more to reduce some weight.";

            //Act
            string actualResult = bmi.Recommendation.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestBMIRecommendation_Return_MessageForObese()
        {
            //Arrange
            BMI bmi = new BMI
            {
                WeightStones = 15,
                WeightPounds = 0,
                HeightFeet = 5,
                HeightInches = 0
            };

            string expectedResult = "Cut back on dietary fat can reduce calories and is heart-healthy! Engage in moderate physical activity on all days of the week to reduce weight.";

            //Act
            string actualResult = bmi.Recommendation.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
