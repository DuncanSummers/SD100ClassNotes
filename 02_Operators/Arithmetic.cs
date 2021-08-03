using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 22;
            int b = 15;

            // addition
            int sum = a + b;
            // subtraction
            int difference = a - b;
            // multiplication
            int product = a * b;
            // division
            int quotient = a / b;
            // remainder
            int remander = a % b;

            DateTime today = DateTime.UtcNow;
            DateTime someDay = new DateTime(1980, 1, 5);
            TimeSpan timeSpan = today - someDay;
        }
    }
}
