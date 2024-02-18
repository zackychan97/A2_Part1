using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            // Arrange
            var calculator = new Calculator(6.0, 3.0);

            // Act
            double result1 = calculator.Add();
            double result2 = Calculator.Add(6.0, 3.0);

            // Assert
            Assert.AreEqual(9.0, result1);
            Assert.AreEqual(9.0, result2);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            // Arrange
            var calculator = new Calculator(6.0, 3.0);

            // Act
            double result1 = calculator.Subtract();
            double result2 = Calculator.Subtract(6.0, 3.0);

            // Assert
            Assert.AreEqual(3.0, result1);
            Assert.AreEqual(3.0, result2);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            // Arrange
            var calculator = new Calculator(6.0, 3.0);

            // Act
            double result1 = calculator.Multiply();
            double result2 = Calculator.Multiply(6.0, 3.0);

            // Assert
            Assert.AreEqual(18.0, result1);
            Assert.AreEqual(18.0, result2);
        }

        [TestMethod()]
        public void DivideTest()
        {
            // Arrange
            var calculator = new Calculator(6.0, 3.0);

            // Act
            double result1 = calculator.Divide();
            double result2 = Calculator.Divide(6.0, 3.0);

            // Assert
            Assert.AreEqual(2.0, result1);
            Assert.AreEqual(2.0, result2);
        }
    }
}