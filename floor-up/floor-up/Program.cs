using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace floor_up
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("輸入階梯數:");
            num = int.Parse(Console.ReadLine());
            for (int k = num; k >= 1; k--)
            {
                if (k == num)
                {
                    for (int i = 1; i <= k; i++)
                    {
                        if(i == 1)
                        {
                            Console.Write("   ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                  
                    }
                    Console.WriteLine("_");
                }
                if (k < num)
                {
                    Console.WriteLine("|");
                }
                for (int i = 1; i <= k; i++)
                {
                    if (i == 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.Write("_");
                if (k == 1)
                {
                    Console.Write("|");
                }

            }
            Console.ReadKey();
        }
    }
}
