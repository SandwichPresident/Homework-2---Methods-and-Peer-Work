/* Student Names: Vicky Ni and Sam Booth
 * IGME.201.01 - Interac Des & Alg Prob Sol III
 * Due: 10/12/25
 */

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static int addNums(int num1, int num2)
        {
            return num1 + num2;
        }

        static void Main(string[] args)
        {
            int samNum;
            int vickyNum;

            //Initialize
            samNum = 24;
            vickyNum = 4;

            Console.WriteLine("Sam's favorite number is " + samNum);
            Console.WriteLine("Vicky's favorite number is " + vickyNum);

            private int subtractNums(int num1, int num2)
            {
                return num1 - num2;
            }

            //start of our actual program
            int sumNum = addNums(samNum, vickyNum);
            Console.WriteLine("The sum of Sam and Vicky's favorite numbers is " + sumNum);
            int difference = subtractNums(samNum, vickyNum);
            Console.WriteLine("The difference of Sam and Vicky's favorite numbers is " + difference);

        }  
    }
}
