using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newtons_metode
{
    class GFG
    {

        // Function to return the square root of
        // a number using Newtons method
        static double squareRoot(double n, double l)
        {
            // Assuming the sqrt of n as n only
            double x = n;

            // The closed guess will be stored in the root
            double root;

            // To count the number of iterations
            int count = 0;

            while (true)
            {
                count++;

                // Calculate more closed x
                root = 0.5 * (x + (n / x));

                // Check for closeness
                if (Math.Abs(root - x) < l)
                    break;

                // Update root
                x = root;
            }

            return root;
        }

        // Driver code
        public static void Main()
        {
            double n = 327;
            double l = 0.00001;

            Console.WriteLine(squareRoot(n, l));
            Console.ReadKey();
        }
    }

    // This code is contributed by AnkitRai01
}
