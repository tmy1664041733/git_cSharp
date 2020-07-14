using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hollo World");
            //Console.ReadKey();
            //double firstNumber;
            //string userName;
            int a,b;
            Console.WriteLine("输入一个数字a:");
            a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("输入一个数字b:");
            b= Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("a大于b");
            }else if(a<b)
            {
                Console.WriteLine("a小于b");
            }
            else if (a == b)
            {
                Console.WriteLine("a等于b");
            }
            Console.WriteLine("结果");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.ReadKey();

            //Console.WriteLine("userName:");
            //userName = Console.ReadLine();
            //Console.WriteLine(userName);
            //Console.ReadKey();
        }
    }
}
