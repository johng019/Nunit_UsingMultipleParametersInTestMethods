using Calculator;
using NUnit.Framework;

namespace NunitTestCalculator
{
    [TestFixture]
    public class NUnitCalcTest
    {
        //Try naming the method for the purpose it is intended

        [TestCase(4, 5)]
        [TestCase(8, 2)]
        [TestCase(2, 9)]
        public void VerifyAddMethodReturnsCorrectSumOfTwoNumbers(double num1, double num2)
        {
            //Arrange..set up the test
            CalculatorClass obj = new CalculatorClass();
            //Act...actionable event
            double result = obj.Add(num1, num2);
            //Assert..expected result
            Assert.That(result,Is.EqualTo(result));
        }

        //continue to set up additional tests in the same manner
        [TestCase(4, 5)]
        [TestCase(8, 2)]
        [TestCase(2, 9)]
        public void VerifySubtractMethodReturnsCorrectDifferenceOfTwoNumbers(double num1, double num2)
        {
            CalculatorClass obj2 = new CalculatorClass();
            double result = obj2.Subtract(num1, num2);
            Assert.That(result, Is.EqualTo(result));
        }

        [TestCase(4, 5)]
        [TestCase(8, 2)]
        [TestCase(2, 9)]
        public void VerifyMultiplyMethodReturnsCorrectProduct(double num1, double num2)
        {
            CalculatorClass obj3 = new CalculatorClass();
            double result = obj3.Multiply(num1, num2);
            Assert.That(result, Is.EqualTo(result));
        }

        [TestCase(50, 5)]
        [TestCase(8, 2)]
        [TestCase(27, 9)]
        public void VerifyDivideMethodReturnsCorrectDividend(double num1, double num2)
        {
            CalculatorClass obj4 = new CalculatorClass();
            double result = obj4.Divide(num1, num2);
            Assert.That(result, Is.EqualTo(result));
        }

        [TestCase(4, -5)]
        [TestCase(-8, 2)]
        [TestCase(-2, -9)]
        public void VerifyNegativeNumbersReturnCorrectSum(double num1, double num2)
        { 
            CalculatorClass obj5 = new CalculatorClass();
            double result = obj5.Add(num1, num2);
            Assert.That(result, Is.EqualTo(result));  
        }

        [TestCase(4.2, 5.6)]
        [TestCase(8.9, 2.3)]
        [TestCase(2.4, 9.7)]
        public void VerifyDecimalNumbersReturnCorrectSum(double num1, double num2)
        {
            CalculatorClass obj6 = new CalculatorClass();
            double result = obj6.Add(num1,num2);
            Assert.That(result, Is.EqualTo(result));
        }
    }
}
