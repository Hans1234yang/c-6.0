using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda作属性
{
    class Program   //lambda作属性
    {
        static void Main(string[] args)
        {
            User1 u1 = new User1()   //对象初始化器，不仅可以给属性赋值，也可以给字段赋值
            {
                Xing = "杨",
                Ming = "旦"
            };
            string result = u1.FullName;
            Console.WriteLine(result);


            User2 u2 = new User2()     //对象初始化器
            {
                Xing = "杨",
                Ming = "先生"
            };

            string result2 = u2.FullName;
            Console.WriteLine(result2);
          

         
            Console.ReadLine();
        }
    }

    //老写法
    public class User1
    {
        public string Xing { get; set; }
        public string Ming { get; set; }

        public string FullName
        {
            get
            {
                return $"{ Xing}{Ming }";
            }
        }
    }

    //新写法
    public class User2
    {
        public string Xing { get; set; }
        public string Ming { get; set; }

        public string FullName => $"{Xing},{Ming}";
    }
}
