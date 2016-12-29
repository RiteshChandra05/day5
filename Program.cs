using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise
{
    class Program
    {

        static void Main(string[] args)
        {
            int a = 5;
            int b = 0;
            double c;


            try
            {
                c = a / b;
                Console.WriteLine(c);
            }
            catch
            {
                Console.WriteLine("no operation");
            }
        }
    }
}
