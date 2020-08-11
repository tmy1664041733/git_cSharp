using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBase
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用while循环计算
            //输入班级人数，然后依次输入学员成绩，计算班级学员的平均成绩和总成绩
            //Console.WriteLine("请输入班级人数");
            //int man = Convert.ToInt32(Console.ReadLine());//存放班级人数
            //int i=1;//定义自动累加变量i
            //int sum = 0;//定义接收总成绩变量
            //int average = 0;//定义接收平均成绩变量
            ////进行条件判断，i<班级人数执行循环体
            //while (i <=man) {

            //    Console.WriteLine("请输入第{0}个学员的成绩",i);
            //    int grade = Convert.ToInt32(Console.ReadLine());//接收输入的学生成绩
            //    sum += grade;//进行累加运算
            //    i++;//循环变量加一

            //}
            //average = sum / man;//计算平均值
            //Console.WriteLine("班级人数为{0}，学员平均成绩为{1}，学员总成绩为{2}",man,average,sum);
            //Console.ReadKey();
            //老师问学生，这道题你会了吗？如果学生答会了（y）
            //则可以放学，如果学生不会做（n），则老师再讲一遍，再问学生是否会做....
            //知道学生会为止，才能放学
            //知道学生会或者老师讲了10遍还是不会，都要放学
            //循环体：接收学生的输入
            //循环条件：放学条件为：学生会了或者老师讲了10遍
            //string answer ="";
            //int i = 1;
         
            //    while (i <= 3 && answer != "y")
            //    {
            //        Console.WriteLine("第{0}遍这道题你会了吗？",i);
            //        answer = Console.ReadLine();
            //        if (answer=="y")
            //        {
            //            Console.WriteLine("放学了");
            //            break;
            //        }
            //        i++;
            //    }
            //    Console.ReadKey();
            //2006年培养学员80000人，每年增长25%
            //请问按照这种增长速度，那年人数会达到20万
            //循环条件：people >=200000
            //循环体：每年增加25%
            double people = 80000;
            int year = 2006;
            while (people <= 200000) {
                people *= 1.25;
                year++;
            }
            Console.WriteLine("{0}人数会达到20万",year);
            Console.ReadKey();
          
            
           



        }
    }
}
