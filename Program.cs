using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class pyramid
    {
        static void Main(String[] args)
        {
            {
                int i, j, N;
                string n;
                char again = 'y';
                do
                {
                    Console.WriteLine("Enter the value of N");
                    n = Console.ReadLine();
                    N = Convert.ToInt32(n);
                    for (i = 1; i <= N; i++)
                    {
                        for (j = 1; j <= N; j++)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                    Console.WriteLine("Do you want to read it again? Y/N?");
                    again = Console.ReadKey().KeyChar;
                } while (again == 'y');
            }
        }
    }
}
