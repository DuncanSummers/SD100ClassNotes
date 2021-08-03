using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void Comparisons()
        {
            int age = 25;
            string username = "Joshua";
            // when you're comparing something equal use two = signs as such ==

            bool equals = age == 41;
            // bool is going to intialialize with a false flag
            bool userIsAdam = username == "Adam";

            // Inequals comparison use "bang" operator "!="
            bool notEqual = age != 122;
            bool userIsNotJustin = username != "Justin";

            // Not all thing are equal, reference types aren't understood the same way
            List<string> firstList = new List<string>();
            firstList.Add(username);

            List<string> secondList = new List<string>();
            secondList.Add(username);

            bool isEqual = firstList == secondList;


            bool greaterThan = age > 12;
            bool greaterThanOrEqual = age >= 24;
            bool lessThan = age < 66;
            bool lessThanOrEqual = age <= 24;
        }

        [TestMethod]
        public void AndOr()
        {
            bool trueValue = true;
            bool falseValue = false;

            // Or (similar to "logic gates") use "||"
            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrF = falseValue || falseValue;

            // And uses "&&"
            bool tAndT = trueValue && trueValue;
            bool tAndF = trueValue && falseValue;
            bool fAndF = falseValue && falseValue;
        }
    }
}
