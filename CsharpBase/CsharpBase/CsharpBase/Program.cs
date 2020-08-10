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
            Console.WriteLine("请输入班级人数");
            int man = Convert.ToInt32(Console.ReadLine());//存放班级人数
            int i=1;//定义自动累加变量i
            int sum = 0;//定义接收总成绩变量
            int average = 0;//定义接收平均成绩变量
            //进行条件判断，i<班级人数执行循环体
            while (i <=man) {

                Console.WriteLine("请输入第{0}个学员的成绩",i);
                int grade = Convert.ToInt32(Console.ReadLine());//接收输入的学生成绩
                sum += grade;//进行累加运算
                i++;//循环变量加一

            }
            average = sum / man;//计算平均值
            Console.WriteLine("班级人数为{0}，学员平均成绩为{1}，学员总成绩为{2}",man,average,sum);
            Console.ReadKey();
        }
    }
}
