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

            #endregion

            #region Arrays

            #endregion
        }
    }
}
