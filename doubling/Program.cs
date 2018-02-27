using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubling
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an integer variable named `ak` and assign the value `123` to it
            int ak = 123;
            // - Create a function called `doubling` that doubles it's input parameter and returns with an integer
            // - Print the result of `doubling(ak)`
            Console.WriteLine("Result of doubling: {0}",doubling(ak));
            Console.ReadLine();
        }

        public static int doubling (int number)
        {
            return number * 2;
        }
    }
}
