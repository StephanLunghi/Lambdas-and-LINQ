using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas_and_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //   1 An expression which does not return a value, takes no parameters, and evaluates to the string "Hello, World".
            //   2 An expression which returns an integer, takes a single integer parameter, and adds the integer 1 to it.
            //   3 An expression which returns an integer, takes two integer parameters, and raises the second parameter to the power of the first.
            //   4 An expression which returns an integer, takes two integer parameters and sums them.
            //   5 An expression which returns a string, takes two strings, and appends the first to the second.
            // LAMBDA EXPRESSIONS
            Func<string> hello = () => "Hello, World";
            Func< int, int > addOne = x => x + 1;
            Func<int, int, int> power = (x, y) => (int)Math.Pow(y, x);
            Func<int, int, int> sum = (x, y) => x + y;
            Func<string, string, string> append = (x, y) => x + y;


            // LINQ

            //Using LINQ's lambda-syntax, use the expressions numbered above to complete the following. Print to the console the result of each LINQ statement.

            //    Before starting,

            //    Declare a list of sequential integers with a method from the Enumerable class.
            //Declare a list of dummy strings.
            //    Then,

            //  1  Use #2 to add one to a list of integers individually.
            //  2  Use #3 to raise a list of integers to the second power individually.
            //  3  Use #4 to sum a list of integers.
            //  4  Use #5 to concatenate a list of strings, returning an empty string if given an empty list.

            //  5  Use #3 and a method from the Enumerable class in a new lambda expression which returns an integer, 
            //    takes two integer parameters (base and times), and which raises the base to its own value times times. 
            //    Evaluating your function with base of 2 and times of 4 should result in 65536. This is repeated exponentiation, 
            //    also known as tetration, and is frequently expressed in Knuth's up-arrow notation (Links to an external site.)Links to an 
            //    external site. using double up-arrows.

            var numList = Enumerable.Range(1, 10);

            var stringlist = new List<string>() { "Hey", "Look", "At", "Me", "I", "Flying"};
            // NUMBER 1
            var number1 = 
                numList.Select(x => addOne(x));

            foreach (var num in number1)
            {
                Console.WriteLine(num);
            }


            // NUMBER 2

            var number2 = numList.Select(x => power(2,x));

            foreach (var num in number2)
            {
                Console.WriteLine(num);
            }

            // NUMBER 3

            var number3 = numList.Aggregate((previous,next) => sum(previous,next));

            Console.WriteLine(number3);

            // NUMBER 4

            var number4 = stringlist.Aggregate((previous, next) => append(previous, next));

            Console.WriteLine(number4);
            // NUMBER 5

            

            var number5 = Enumerable.Repeat(2, 4).Aggregate((previous, next) => power(previous, next));

            Console.WriteLine(number5);


        }
    }
}
