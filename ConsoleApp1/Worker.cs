using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Worker
    {

        public void Print()
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
        public int Add(int a, int b)
        {
            int resut = 0;
            try 
            {
                resut = a + b;
                return resut;
            }
            catch (Exception ex) 
            {

            }
            return resut;


            
        }
    }
}
