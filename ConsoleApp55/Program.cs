using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int p = 6;
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                    Console.Write(" ");
                }
                for(int k=1;k<=p;k++)
                {
                    Console.Write("*");
                    Console.Write("*");

                }
                p = p - 1;
                Console.WriteLine();
            }
           
           
            Console.ReadLine();

        }
    }
}
    
    