using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    enum orientation : byte
    {
        north = 1,
        south = 2,
        east = 3,
        west = 4
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int a,b;
            //Console.WriteLine("输入一个数字a:");
            //a = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("输入一个数字b:");
            //b= Convert.ToInt32(Console.ReadLine());
            //if (a > b)
            //{
            //    Console.WriteLine("a大于b");
            //}else if(a<b)
            //{
            //    Console.WriteLine("a小于b");
            //}
            //else if (a == b)
            //{
            //    Console.WriteLine("a等于b");
            //}
            //Console.WriteLine("结果");
            //Console.WriteLine("a=" + a);
            //Console.WriteLine("b=" + b);
            //Console.ReadKey();
            //int i;
            //for (i = 1; i < 10; i++)
            //{
            //    Console.WriteLine("{0}",i);
            //}
            //Console.ReadKey();
            //三目运算符
            //int var1 = 7;
            //int var2 = 10;
            double doubleVal = 99.999;
            bool boolVal = true;
            string stringResult;
            //进行数据类型转换布尔类型和浮点型转化为字符型
            stringResult = Convert.ToString(boolVal) + Convert.ToString(doubleVal);
            Console.WriteLine("String:{0}+{1}={2}", boolVal, doubleVal, stringResult);
            Console.ReadKey();
            //枚举类型的使用
            orientation myDirection = orientation.north;
            Console.WriteLine("{0}", myDirection);
            //进行类型转换才能显示枚举的字符值
            string directionString;
            byte directionByte;
            directionByte = (byte)myDirection;
            directionString = Convert.ToString(myDirection);
            Console.WriteLine("{0},{1}", directionString, directionByte);
            Console.ReadKey();
          
        }
    }
}
