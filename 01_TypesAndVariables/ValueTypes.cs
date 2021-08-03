using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            // camelCaseCapitalization
            // Declared Bool
            bool declared;

            // Assigning value
            declared = true;

            // Declared then assigned
            bool declareAndInitialized = false;

            // Still assign value after intial assignment
            declareAndInitialized = true;

        }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char specialCharacter = '\n';
            // chars useful to hold small amount of data
        }

        [TestMethod]
        public void WholeNumbers()
        {
            // Harvard's CS50 course is free and covers bits and whatnot early on if you want to learn about the background
            byte byteMin = 0;
            byte byteMax = 255;
            short shortMin = -32768;
            short shortMax = 32767;
            int intMin = -2147483648;
            int intMax = 2147483647;
            long longMin = -9223372036854775808;
            long longMax = 9223372036854775807;
            int a = 15;
            int b = -2;
        }

        [TestMethod]
        public void Decimals()
        {
            // "https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types"
            // float number require 'f' suffix
            float floatExample = 1.29294894f;
            // double is DEFAULT of a decimal, so doesn't require suffix but can use suffix of 'd' (optional)
            double doubleExample = 1.749292474748;
            // decimal goes a little farther than double, requires 'm' suffix
            decimal decimalExample = 1.292399219232000099m;
        }
            
            // enum is placed outside test methods and is available to all test methods
            enum PastryType { Cake, Cupcake, Eclaire, PetitFour, Croissant };

        [TestMethod]
        public void Enum()
        {
            PastryType myPastry = PastryType.Croissant;
            PastryType yourPastry = PastryType.PetitFour;
        }

        [TestMethod]
        public void Structs()
        {
            // structs are structured data
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(1972, 4, 3);

        }
    }
}
