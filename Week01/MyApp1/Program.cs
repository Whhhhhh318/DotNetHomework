using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            double a, b;
            
            int tag = 1;
            double ret = 0.0;

            Console.WriteLine("Please input the first number: ");
            s = Console.ReadLine();
            a = Double.Parse(s);
            Console.WriteLine("Please input the second number: ");
            s = Console.ReadLine();
            b = Double.Parse(s);
            Console.WriteLine("Please input the operator: ");
            s = Console.ReadLine();

            if (s.Equals("+"))
                ret = a + b;
            else if (s.Equals("-"))
                ret = a - b;
            else if (s.Equals("*"))
                ret = a * b;
            else
            {
                if (b == 0)
                {
                    Console.WriteLine("除数为0， 错误！");
                    tag = 0;
                }
                else
                {
                    ret = a / b;
                    ret = double.Parse(ret.ToString("0.000"));
                }
            }

            if (tag == 1)
                Console.WriteLine($"计算结果为{a} {s} {b} = {ret}");

                
                
        }
    }
}
