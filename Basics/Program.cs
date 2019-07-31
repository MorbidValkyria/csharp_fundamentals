using System; // In here we're importing the System Class library, where the Console.WriteLine() method exists


namespace Basics // A namespace is basically where our project exists
{
    /// <summary>
    /// This is an XML style Documentation or Docstring
    /// Works pretty much like a multi-line comment,
    /// Used to give a brief summary of what a certain Class or Method(function does)
    /// You can specify inputs and outputs
    /// </summary>
    class Program
    {
        /// <summary>
        /// This is the main method, 
        /// We can describe a method's parameters.
        /// </summary>
        /// <param name="args"> Reads input from the command line</param>
        static void Main(string[] args)
        {
            // Single line comment

            /*
                This is a multi-line comment
                Everything enclosed here is ignored by the compiler

                Console.WriteLine("This code is not executed");

                Can be used to comment chunks of code.
             */
            #region Hello World
            Console.WriteLine("Hello World!");
            #endregion

            #region DataTypes, Variables
            // We can declare and assign values to variables in a single line
            int myInt = 5;
            // Or Declare the variable first then assign the value on a different line
            // either way is fine, use whatever way you prefer
            int mySum;
            mySum = myInt + 10;

            // Floats require an f after the numerical value
            float myFloat = 9.9f;
            float sumFloat = 1.0f + myFloat;

            // Unlike floats, doubles can be represented as they are
            double myDouble = 8.55;
            double doubleSum = 2.0 + myDouble;

            // When you concatenate strings, no space is inserted in between
            string myString = "Hello";
            string mySecongString = myString + ",World!";

            Console.WriteLine(myInt);

            // How to print date time
            Console.WriteLine("{0:D}", DateTime.Today);

            #endregion

            #region Conditionals

            int x = 9;

            if (x > 10)
            {
                Console.WriteLine("Greater");
            }
            else
            {
                Console.WriteLine ("Smaller");
            }
            // We can also add else if statements

            int temp = 30;
            if (temp < 10)
            {
                Console.WriteLine("cold");
            }
            else if (temp < 20)
            {
                Console.WriteLine("medium");
            }
            else
            {
                Console.WriteLine("hot");
            }

            // if There's only one statement inside the conditional we can ignore the braces
            if (temp < 10) 
                Console.WriteLine("cold");

            else if (temp < 20) 
                Console.WriteLine("medium");

            else 
                Console.WriteLine("hot");
            #endregion

            #region Loops For, While, Do-While
            // For loop example

            // Iterating through a range 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"The current value of i is {i}");
            }

            // Iterating through a string:
            string s = "I'm Blue dabadi dabada";
            // Just like with conditionals we can avoid braces if only one statement inside the loop
            for (int i = 0; i < s.Length; i++ )  
                Console.WriteLine($"Character {s[i]} at iteration {i}");
            
            // Using substring 
            for (int i = 0; i < s.Length-3; i++)
            {
                if (s.Substring(i, i+4) == "Blue")
                    Console.WriteLine("String contains the Substring Blue!");
                else
                    Console.WriteLine("No Blue inside the string :(");
            }

            /*
                While loops are ineteresting, we first have to define the variable we're going
                to use as a condition
             */

            int myCondition = 0;

            while (myCondition < 9)
            {
                if (myCondition % 2 != 0)
                    Console.WriteLine($"{myCondition} is odd");
                else
                    Console.WriteLine($"{myCondition} is even");
            
                myCondition++; // Increments myCondition by one each iteration so the loop terminates
            }
            // Do While is pretty special, even if the condition is false, it gets executed at least once
            bool mySecondCondition = false;

            do
            {
                Console.WriteLine("Even if the condition is false, this gets executed at least once.");
            } while (mySecondCondition);
            #endregion

            #region Arrays

            #endregion
        }
    }
}
