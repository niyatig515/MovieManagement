using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PracticeAssignment2
{
    public class PatternPrinting
    {
        static void Main()
        {
            Pattern(7);
        }
        static void Pattern(int n)
        {
            for (int i = 0; i < n; i++)
            {
                //For first space
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                //For Printing first Hash
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                //For printing middle Spaces
                for (int j = 0; j < (4 * (n - 1)) - 4 * i; j++)
                {
                    Console.Write(" ");
                }
                //For Printing last Hash
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            //For Printing another half pattern
            for (int i = 0; i < n; i++)
            {
                //For first space
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                }
                //For Printing first Hash
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("#");
                }
                //For printing middle Spaces
                for (int j = 0; j < 4 * i; j++)
                {
                    Console.Write(" ");
                }
                //For Printing last Hash
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}