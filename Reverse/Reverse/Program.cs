using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Welcome to Reverse Game");
            Console.WriteLine("The rules are simple. You type 3 numbers. I give you back the 3 numbers in reverse order.");
            Console.WriteLine("Please give me your first number");
            string firstNumber = Console.ReadLine();
            int firstNumberFuture = int.Parse(firstNumber);
            Console.WriteLine("Good Please give me your second number");
            string secondNumber = Console.ReadLine();
            int secondNumberFuture = int.Parse(secondNumber);
            Console.WriteLine("Good Please give me your third number");
            string thirdNumber = Console.ReadLine();
            int thirdNumberFuture = int.Parse(thirdNumber);
            Console.WriteLine("");
            Console.WriteLine("Your numbers reverse is:");

            Stack myStack = new Stack();
            myStack.Push(firstNumberFuture);
            myStack.Push(secondNumberFuture);
            myStack.Push(thirdNumberFuture);

            // Displays the properties and values of the Stack.
            PrintValues(myStack);
            Console.ReadLine();
        }
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("{0}", obj);
            Console.WriteLine();
        }
    }
}