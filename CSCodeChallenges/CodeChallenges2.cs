using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeChallenges
{
    internal class CodeChallenges2
    {
        static int evenFibonacciSum(int limit)
        {
            Console.WriteLine("Sum of even Fibonacci numbers under 4000000:\n");
            if (limit < 2)
            {
                 return 0;
            }

            // Initialize first two even Fibonacci numbers and their sum
            int eFib1 = 0;
            int eFib2 = 2;
            int sum = eFib1 + eFib2;

            // calculating sum of even Fibonacci value
            while (eFib2 <= limit)
            {

                // get next even value of Fibonacci sequence
                int eFib3 = 4 * eFib2 + eFib1;

                // If we go beyond limit, we break loop
                if (eFib3 > limit)
                    break;

                // Move to next even number and update sum
                eFib1 = eFib2;
                eFib2 = eFib3;
                sum += eFib2;
            }

            return (int)sum;
        }

        
        public static void Main()
        {
            int limit = 4000000;
            Console.Write(evenFibonacciSum(limit));

        }

    }
}
