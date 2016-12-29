//nullables types and anonymous types, var

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise
{
    class Program
    {
        public int add()
        {
            var a = 5;
            int b = 5;

            return a + b;
        }

        static void Main(string[] args)
        {


            int? num1 = null;
            int? num2 = 22;
            double? num3 = new double?();
            Console.WriteLine("." + num1 + " " + num2 + " " + num3 + ".");// prints blank space at num1 and num3


            var any = new
            {
                name = "first",
                rollno = 5,
                present = true
            };

            Console.WriteLine(any.name);
            Console.WriteLine(any.rollno);
            Console.WriteLine(any.present);

            Program a1 = new Program();
            Console.WriteLine("a+b=" + a1.add());


        }
    }
}