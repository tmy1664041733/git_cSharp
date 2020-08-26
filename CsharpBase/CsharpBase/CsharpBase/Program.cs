using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBase
{
    //声明一个枚举类型变量
    public enum Gender
    { 
       男,
       女
    }
    //
    public enum state
    { 
         one=1,
         two,
        three
    }
    //声明一个结构体
    /// <summary>
    /// 
    /// </summary>
    public struct Person
    {
        public string _name;//成员-字段，字段一般以下划线开头_
        public string _age;
        public string _student;
    }
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
            //double people = 80000;
            //int year = 2006;
            //while (people <= 200000) {
            //    people *= 1.25;
            //    year++;
            //}
            //Console.WriteLine("{0}人数会达到20万",year);
            //Console.ReadKey();
            ////通过函数返回一个数组中的最大值
            // int[] myList = {1,2,85,47,55,17,64,32,66,105,99,33,20};

            //      int Max = MaxVal(myList);
            //      Console.WriteLine("最大值为：{0}",Max);
            //      Console.ReadKey();
            //通过params参数接收可变参数，进行累加计算
            //int sum = SumVal(1,5,52,60,14,52,66,8);
            //Console.WriteLine("累加值为{0}",sum);
            //Console.ReadKey();
            //通过引用来调用参数
            //int mylist = 5;
            // int ss = Val(ref mylist);
            // Console.WriteLine("ss的值为：{0},mylist值为：{1}",ss,mylist);
            // Console.ReadKey();
            //三元表达式的使用
            //语法：表达式1？表达式2：表达式3；
            //使用三元表达式计算两个数的最大值
            //Console.WriteLine("请输入第一个数");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int max = num1 > num2 ? num1 : num2;
            //Console.WriteLine("最大值为{0}",max);
            //Console.ReadKey();
            ////创建随机数对象
            //Random r = new Random();
            ////随机数对象调用方法产生随机数
            ////int rNumber = r.Next(1,10);//产生  大于等于1，小于10的随机数
            //while (true) {
            //    int rNumber = r.Next(1, 10);//产生  大于等于1，小于10的随机数
            //    Console.WriteLine(rNumber);
            //    Console.ReadKey();
            //}
            //使用随机数计算一个人上辈子
            ////1创建一个随机数对象
            //Random r = new Random();
            ////2随机数对象调用方法,生成1-7的随机数
            //while (true)
            //{
            //    int rNumber = r.Next(1, 8);
            //    //
            //    Console.WriteLine("请输入姓名：");
            //    string name = Console.ReadLine();
            //    switch (rNumber)
            //    {
            //        case 1:
            //            Console.WriteLine("{0}上辈子是土豪", name);
            //            break;
            //        case 2:
            //            Console.WriteLine("{0}上辈子是乞丐", name);
            //            break;
            //        case 3:
            //            Console.WriteLine("{0}上辈子是大官", name);
            //            break;
            //        case 4:
            //            Console.WriteLine("{0}上辈子是皇帝", name);
            //            break;
            //        case 5:
            //            Console.WriteLine("{0}上辈子是和尚", name);
            //            break;
            //        case 6:
            //            Console.WriteLine("{0}上辈子是普通人", name);
            //            break;
            //        case 7:
            //            Console.WriteLine("{0}上辈子是妓女", name);
            //            break;
            //        case 8:
            //            Console.WriteLine("{0}上辈子是龟公", name);
            //            break;
            //        case 9:
            //            Console.WriteLine("{0}上辈子是司机", name);
            //            break;
            //        case 10:
            //            Console.WriteLine("{0}上辈子是程序员", name);
            //            break;
            //    }
            //    Console.ReadKey();
            //}
            //常量的定义方法
            //声明的语法：
            // const 变量类型 变量名= 值;
           // const int number = 60;//常量不能被重新赋值
            //枚举的使用
            //语法：
            //[public] enum  枚举名
            //{ 
            //    值1,
            //    值2,
            //}
            //public 访问修饰符  表示公开的，谁都可以访问
            //enum 声明枚举的关键字
            //将枚举声明在命名空间的下面，类的外面，表示在这个命名空间下，所有的类都可以使用这个枚举。
            //Gender g = Gender.男;
            //Console.WriteLine("你的性别是{0}",g);
            //Console.ReadKey();
            //枚举类型默认可以转换为int类型
            //state s = state.one;
            //int c = (int)s;
            //Console.WriteLine("{0}",c);
            //Console.ReadKey();
            ////int类型转换为枚举类型
            //int t = 2;
            //state t1 = (state)t;
            //Console.WriteLine("{0}",t1);
            //Console.ReadKey();
            ////所有类型都能转换为string类型
            //#region 枚举类型转换成字符串
            //string cc = s.ToString();
            //Console.WriteLine("{0}",cc);
            //Console.ReadKey();
            //#endregion
            //#region 字符串转换为枚举类型
            //string rr = "0";
            //state dd = (state)Enum.Parse(typeof(state),rr);
            //#endregion
            //枚举类型默认和 int类型兼容，所以可以通过强制类型转换进行互相转换，
            //当转换一个枚举中没有的值的时候，不会抛出异常，而是直接将数字显示出来
            //枚举同样可以和string类型进行互相转换，如果将枚举类型转换为string类型，则直接调用ToString()
            //如果将字符串转换成枚举类型则需要下面一行代码：
            //(要转换的枚举类型)Enum.Parse(typeof(要转换的枚举类型),"要转换的字符串");
            //如果要转换的字符串是数字，则就算枚举中没有，也不会抛异常。
            //如果转换的字符串是文本，如果枚举中没有则会抛出异常
            //使用枚举类型实现接受用户输入的数字，输入枚举的英文字符
           // Console.WriteLine("请输入：1--one  ,2--two ,3-three");
           //string input= Console.ReadLine();
           // switch(input){
           //     case "1": state s1 = (state)Enum.Parse(typeof(state),input);
           //             Console.WriteLine("{0}",s1);
           //             Console.ReadKey();
           //              break;
           //     case "2": state s2 = (state)Enum.Parse(typeof(state), input);
           //          Console.WriteLine("{0}",s2);
           //             Console.ReadKey();
           //              break;
           //     case "3": state s3 = (state)Enum.Parse(typeof(state), input);
           //          Console.WriteLine("{0}",s3);
           //             Console.ReadKey();
           //              break;
           // }
            ////数组得使用
            //int[] nums = new int[10];
            ////通过循环给数组赋值
            //for (int i = 0; i < nums.Length; i++) {
            //    nums[i] = i;
            //}
            ////输入数组得值
            //for (int i = 0; i < nums.Length; i++) {
            //    Console.WriteLine("{0}",nums[i]);
            //}
            //Console.ReadKey();
            ////定义一个数组，找出数组中得最大值了最小值，以及平均值
            //int[] nums = { 1, 2, 2, 20, 16, 17, 33, 17, 3, 9, 8, 10 };
            //int max = nums[0];
            //int min = nums[0];
            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++) {
            //    if (nums[i] > max) {
            //        max = nums[i];
            //    }
            //    if (nums[i] < min) {
            //        min = nums[i];
            //    }
            //    sum = sum + nums[i];
            //}
            //Console.WriteLine("nums数组的最大值为：{0}最小值为：{1}，平均值为：{2}",max,min,sum/nums.Length);
            //Console.ReadKey();
            //给出一个字符串数组，使用|进行连接 例如：张三|李四....,
            //string[] str = {"张三","李四","王五","张麻子"};
            //string strs="";
            //for (int i = 0; i < str.Length-1; i++) {
            //    strs = strs+str[i] + "|";
            //}
            //Console.WriteLine("{0}",strs+str[str.Length-1]);
            //Console.ReadKey();
            //将一个字符串元素的数组顺序进行反转{“我”，“是”，“好人”}{“好人”,"是"，“我”}
            string[] str_wz = { "我","是","好人"};
            //
            for (int i = 0; i < str_wz.Length / 2; i++)
            {
                string temp = str_wz[i];
                str_wz[i] = str_wz[str_wz.Length - 1 - i];
                str_wz[str_wz.Length - 1 - i] = temp;
            }
            for (int i = 0; i < str_wz.Length; i++) {
                Console.WriteLine("{0}",str_wz[i]);      
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 返回整型数组中的最大值
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns></returns>
        static int MaxVal(int[] intArray)
        {
            int Max = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
            {
                if (Max < intArray[i])
                {

                    Max = intArray[i];
                }
            }
            return Max;
        }
        /// <summary>
        /// 使用params参数接收个数不定的参数
        /// </summary>
        /// <param name="vals"></param>
        /// <returns></returns>
        static int SumVal(params int[] vals) {
            int sum = 0;
            foreach(int val in vals){
                sum += val;
            }
            return sum;
        
        }
        /// <summary>
        /// 传入引用参数
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        static int Val(ref int val) {
            val = val * 2;
            return val;
           
        }
    }
}
