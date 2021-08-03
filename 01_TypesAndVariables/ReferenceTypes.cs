using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ResourceTypes
    {
        [TestMethod]
        public void Strings()
        {
            string declared;

            declared = "This is initialized";

            string declareAndInitialized = "This is both declared and initialized";

            string firstName = "Duncan";
            string lastName = "Summers";

            // concatenation
            string concatenatedFullName = firstName + " " + lastName; // "Duncan Summers"

            string compositeFormatting = string.Format("{0} {1}", firstName, lastName);

            Console.WriteLine("Hi, I'm {0}!!", firstName);

            // Interpolation
            string interpolatedFormatting = $"{firstName} {lastName}";

            Console.WriteLine(firstName);
            Console.WriteLine(concatenatedFullName);
            Console.WriteLine(compositeFormatting);
            Console.WriteLine(interpolatedFormatting);
        }

        [TestMethod]
        public void Collections()
        {
            // arrays use [] after string to signify array
            string greeting = "Greetings";

            string[] stringArray = { "Hello", "Hi", "Goodbye", greeting };

            // pass index in through brackets of object (keep in mind index items start at "0"
            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);

            stringArray[2] = "Good Morning";
            Console.WriteLine(stringArray[2]);

            // lists are more flexible than arrays
            // lists require a "using statement (at very top)" before using list. ctrl+ . "using system.collections.generic"
                                                    // This declares a list of empty strings
            List<string> listOfString = new List<string>();
            List<int> listOfInts = new List<int>();

            // to add a string to your list of strings
            listOfString.Add("Here's a string"); //index id of 0
            listOfString.Add("292919"); // index id of 1

            listOfInts.Add(7);

            // Queue's
            // first in first out
            Queue<string> firstInFirstOut = new Queue<string>();

            firstInFirstOut.Enqueue("I'm first");
            firstInFirstOut.Enqueue("I'm next");

            // peek let's you look at what's next in queue
            Console.WriteLine(firstInFirstOut.Peek());

            // Stacks
            // work opposite of cues, last in first out
            Stack<string> firstInLastOut = new Stack<string>();

            firstInLastOut.Push("I'm a bottom bun");
            firstInLastOut.Push("I'm a meat");
            firstInLastOut.Push("I'm a top bun");

            Console.WriteLine(firstInLastOut.Peek());

            // Dictionaries
            // one of best and most powerful form of collections
            // they use a "key value pair", allowing you to go to any value
            //key   value
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

            keyAndValue.Add(7, "Agent");

            string atSeven = keyAndValue[7];

            Dictionary<string, string> dictionaryDefinition = new Dictionary<string, string>();

            dictionaryDefinition.Add("Duck", "It quacks");

            string definitionOfDuck = dictionaryDefinition["Duck"];

            Console.WriteLine(definitionOfDuck);
        }

        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();
            // rng is a random class, which is a built-in class in C#

            int randomNumber = rng.Next();
            Console.WriteLine(randomNumber);
        }
    }
}
