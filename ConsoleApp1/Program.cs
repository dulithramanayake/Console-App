using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Program
    {
        static Worker worker = new Worker();
        static void Main(string[] args)
        {


            //int returnResult = worker.Add(2, 2);
            //Console.WriteLine(returnResult);
            //Console.ReadLine();

            CheckIf();


        }

        static void CheckIf()
        {
            int x = 8;

            if (x > 10)
            {
                if (x > 20)
                {
                    Console.WriteLine("X is Less than 5");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("X is Less than 5");
                    Console.ReadLine();
                }

                //Console.WriteLine("X is Greater than 10");
                //Console.ReadLine() ;
            }
            else if (x < 5)
            {
                Console.WriteLine("X is Less than 5");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("X is Less than 10");
                Console.ReadLine();
            }
        }

    }
}
