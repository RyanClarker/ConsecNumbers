using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static void FindSum(ref int n)
        {
            bool found = false;

                for (int start = 1; start < n; start++)
                {
                    int sum = 0;

                    for (int p = start; p < n; p++)
                    {
                        sum += p;

                        if (sum == n)
                        {
                            found = true;
                            for (int q = start; q <= p; q++)
                            {
                                Console.Write(q + " ");
                            }
                            break;
                        }
   
                    }

                }

                if (!found)
                {
                    Console.WriteLine("Does not exsist.");
                }
            }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            FindSum(ref n);
        }
    }
}
