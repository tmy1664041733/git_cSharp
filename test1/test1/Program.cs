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
            ///***占位符的使用**/
            //int num1 = 10;
            //int num2 = 20;
            //int num3 = 30;
            //Console.WriteLine("第一个数字是{0}，第二个数字是{1}，第三个数字是{2}",num1,num2,num3);
            //Console.ReadKey();
            ///**定义4个变量存储姓名、性别、年龄、电话*/
            //string name = "张三";
            //char gender = '男';
            //int age = 30;
            //string tel = "15826798354";
            //Console.WriteLine("我的名字叫{0}，我是{1}生，我今年{2}岁，我的电话号码是{3}",name,gender,age,tel);
            //Console.ReadKey();
            ///*交换变量值*/
            //int s1 = 3;
            //int s2 = 10;
            //int temp = s1;
            //s1 = s2;
            //s2 = temp;
            //Console.WriteLine("s1的值为{0}，s2的值为{1}",s1,s2);
            //Console.ReadKey();
            ///**接收用户输入*/
            //Console.WriteLine("请输入姓名");
            //string sr = Console.ReadLine();
            //Console.WriteLine("我的名字是{0}", sr);
            //Console.ReadKey();
            ///**练习1*/
            //Console.WriteLine("小姐姐，那你喜欢吃什么水果");
            //string fruits = Console.ReadLine();
            //Console.WriteLine("我也喜欢吃{0}",fruits);
            //Console.ReadKey();
            /**转义字符**/
            //  \n:表示换行
            // \":表示英文的半角双引号
            // \t:表示表示一个tab键的空格
            // \b:表示退格键，放在字符的两边没有效果
            // \r\n:windows操作系统只认识\r\n,不认识\n
            // \\:表示一个\
            // @ :01 取消\在字符串中的转义作用   02 保留字符串原格式输出
            //Console.WriteLine("今天天气很好\n我们去兜风");
            //Console.WriteLine("这是一个什么样的\"树\"");
            //Console.ReadKey();
            //一元+  - 运算符
            //var ss = 5;
            //var v1 = 10;
            //ss = +v1;
            //Console.WriteLine("一元运算符\"+\"ss = +v1的运算结果：ss={0},v1={1}", ss, v1);
            //ss = -v1;
            //Console.WriteLine("一元运算符\"-\"ss = -v1的运算结果：ss={0},v1={1}", ss, v1);
            //Console.ReadKey();
            ////一元运算符 ++ / --
            //var num1 = 5;
            //var num2 = 10;
            //num1 = ++num2;
            //Console.WriteLine("执行表达式num1 = ++ num2表达式后，num1的值={0},num2的值={1}",num1,num2);
            //num1 = num2++;
            //Console.WriteLine("执行表达式num1 =  num2++表达式后，num1的值={0},num2的值={1}", num1, num2);
            //Console.ReadKey();
            ///**if条件语句的使用*/
            //var a = 4;
            //var b = 5;
            //if (a > b) {
            //    Console.WriteLine("a的值为{0}",a);
            //} else if(a<=b){
            //    Console.WriteLine("b的值为{0}",b);           
            //}
            //Console.ReadKey();
            //循环do while 
            //int i=1;
            //do
            //{
            //    Console.WriteLine("i的值为{0}", i++);

            //} while (i < 1000);
            //Console.ReadKey();
            /**隐式类型转换**/
            //满足隐式类型转换的条件：1 两种类型兼容  例如：int 和double 兼容（都是数字类型） 2 目标类型大于原类型 例如：double > int 小的转换为大的
            //int c = 20;
            //double s = c;
            //Console.WriteLine("{0}",s);
            //Console.ReadKey();
            /**显示类型转换**/
            //1、两种类型相兼容 int --- double
            //2、大的转成小的  double  -- int 
            //语法 :(要转换的类型)要转换的值  例如：int a = (int)s;
            //double xx = 26.2;
            //int ss = (int)xx;
            //Console.WriteLine("{0}",ss);
            //Console.ReadKey();
            ////例子1
            //int a = 20;
            //int b = 6;
            //double c = a / b;
            //Console.WriteLine("{0}",c);
            //Console.ReadKey();
            ////例子2
            //int dd = 30;
            //int d = 20;
            //double e = dd * 0.1 / d;
            //Console.WriteLine("{0:0.0}",e);
            //Console.ReadKey();
            /**计算118天是几周几天*/
            //int totalday = 118;
            //int week = totalday / 7;
            //int day = totalday % 7;
            //Console.WriteLine("{0}天是{1}周零{2}天",totalday,week,day);
            //Console.ReadKey();
            //如果两个类型之间不兼容，使用convert 进行转换
            //string ss = "123";
            //double r = Convert.ToDouble(ss);
            //Console.WriteLine("{0}",r);
            //Console.ReadKey();
            //练习 读取用户输入的姓名，语文、数学、英语成绩  在控制台输出XX的总成绩是XX,平均成绩是XX
            //Console.WriteLine("请输入姓名：");
            //string name = Console.ReadLine();
            //Console.WriteLine("请输入语文成绩");
            //string strChinese = Console.ReadLine();
            //Console.WriteLine("请输入数学成绩");
            //string strMath = Console.ReadLine();
            //Console.WriteLine("请输入英语成绩");
            //string strEnglish = Console.ReadLine();
            ////进行类型转换
            //int chinese = Convert.ToInt32(strChinese);
            //int math = Convert.ToInt32(strMath);
            //int english = Convert.ToInt32(strEnglish);

            //Console.WriteLine("{0}的总成绩为{1}，平均成绩为：{2}",name, chinese + math + english, (chinese + math + english)/3);
            //Console.ReadKey();
            //函数实现数据交换
            //int[] IntArray = { 1,2,8,10,50,34,47};
            //int dd = MaxValue(IntArray);
            //Console.WriteLine("输出数组的最大值：{0}",dd);
            //Console.ReadKey();
            ////参数数组的使用 
            //int sum = SumVals(1, 5, 9, 12, 52, 33);
            //Console.WriteLine("求和：{0}",sum);
            //Console.ReadKey();
            //判断一个年份是否是闰年
            //int year = Convert.ToInt32(Console.ReadLine());
            //bool flag = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            //if (flag)
            //{
            //    Console.WriteLine("{0}年是闰年", year);
            //}
            //else {
            //    Console.WriteLine("{0}年不是闰年", year);
            //}
            //Console.ReadKey();
            //if else 条件判断语句例子1
            //Console.WriteLine("请输入成绩：");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if (score >= 90) {
            //    Console.WriteLine("成绩为A");
            //}
            //else if (score >= 80 && score < 90)
            //{
            //    Console.WriteLine("成绩为B");
            //}else if(score >= 70 && score < 80){
            //    Console.WriteLine("成绩为C");
            //}
            //else if (score >= 60 && score < 70) {
            //    Console.WriteLine("成绩为D");
            //}
            //else if (score <60)
            //{
            //    Console.WriteLine("成绩为E");
            //}
            //Console.ReadKey();
            ////使用if-else-if语句比较三个数的大小
            //Console.WriteLine("请输入第一个数字");
            //int one = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int two = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第三个数字");
            //int three = Convert.ToInt32(Console.ReadLine());

            //if (one > two && one > three) {
            //    Console.WriteLine("最大值为{0}",one);
            //}else if(two > one && two > three){
            //   Console.WriteLine("最大值为{0}", two);
            //}
            //else if (three > one && three > two) {
            //    Console.WriteLine("最大值为{0}", three);
            //}
            //Console.ReadKey();
            //异常的捕获
            //Console.WriteLine("请输入一个值");
            //try {
            //    int a = Convert.ToInt32(Console.ReadLine());
            //}
            //catch {
            //    Console.WriteLine("输入的值类型不对");
            //    Console.ReadKey();
            //}
            //switch case 多条件选择语句的使用
            //根据员工的年终评定结果：A （+1000）、B（+500）、C（+200）、D（0）、E（-500）发放奖金
            //初始工资为5000
            int salary = 5000;
            bool flag = true;
            Console.WriteLine("请输入员工的评定结果：");
            string grade = Console.ReadLine();
            switch (grade)
            {
                case "A": salary += 1000;
                    break;
                case "B": salary += 1000;
                    break;
                case "C": salary += 1000;
                    break;
                case "D": salary += 1000;
                    break;
                case "E": salary += 1000;
                    break;
                default:
                    Console.WriteLine("输入错误，退出程序");
                    flag = false;
                    break;
            }
            if (flag) {
                Console.WriteLine("员工等级为{0}，工资为：{1}", grade, salary);
            }
            Console.ReadKey();

            
        }
        /// <summary>
        /// 进行数据交换
        /// </summary>
        /// <param name="IntArray">接收参数数组</param>
        /// <returns></returns>
        static int MaxValue(int[] IntArray)
        {
            int MaxVal = IntArray[0];
            for (int i = 1; i < IntArray.Length; i++) {

                if (MaxVal < IntArray[i]) {
                    MaxVal = IntArray[i];
                }
            }
            return MaxVal;
        }
        /// <summary>
        /// 进行求和运算
        /// </summary>
        /// <param name="vals"></param>
        /// <returns></returns>
        static int SumVals(params int[] vals) {
            int sum = 0;
            foreach (int val in vals)
            { 
                sum += val;
            }
            return sum;
        }
    }
}
