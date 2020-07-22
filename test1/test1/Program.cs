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
    struct route
    {
        public orientation direction;
        public double distance;
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
            ////int var2 = 10;
            //double doubleVal = 99.999;
            //bool boolVal = true;
            //string stringResult;
            ////进行数据类型转换布尔类型和浮点型转化为字符型
            //stringResult = Convert.ToString(boolVal) + Convert.ToString(doubleVal);
            //Console.WriteLine("String:{0}+{1}={2}", boolVal, doubleVal, stringResult);
            //Console.ReadKey();
            ////枚举类型的使用
            //orientation myDirection = orientation.north;
            //Console.WriteLine("{0}", myDirection);
            ////进行类型转换才能显示枚举的字符值
            //string directionString;
            //byte directionByte;
            //directionByte = (byte)myDirection;
            //directionString = Convert.ToString(myDirection);
            //Console.WriteLine("{0},{1}", directionString, directionByte);
            //Console.ReadKey();
            //route myRoute;
           // int myDirection = -1;
            //
            //string name = "张三";
            //int age = 30;
            //string email = "zhangsan@qq.com";
            //string address = "广州市";
            //decimal salary = 5000m;
            //Console.WriteLine("我叫"+name+",我住在"+address+",我今年"+age+"了，我的邮箱地址是"+email+",我的工资是"+salary+"元");
            //Console.ReadKey();
            /***占位符的使用**/
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            Console.WriteLine("第一个数字是{0}，第二个数字是{1}，第三个数字是{2}",num1,num2,num3);
            Console.ReadKey();
            /**定义4个变量存储姓名、性别、年龄、电话*/
            string name = "张三";
            char gender = '男';
            int age = 30;
            string tel = "15826798354";
            Console.WriteLine("我的名字叫{0}，我是{1}生，我今年{2}岁，我的电话号码是{3}",name,gender,age,tel);
            Console.ReadKey();
            /*交换变量值*/
            int s1 = 3;
            int s2 = 10;
            int temp = s1;
            s1 = s2;
            s2 = temp;
            Console.WriteLine("s1的值为{0}，s2的值为{1}",s1,s2);
            Console.ReadKey();
            /**接收用户输入*/
            Console.WriteLine("请输入姓名");
            string sr = Console.ReadLine();
            Console.WriteLine("我的名字是{0}", sr);
            Console.ReadKey();
        }
    }
}
