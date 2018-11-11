using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda作为函数体
{
    class Program
    {
        static void Main(string[] args)
        {
            User1 u1 = new User1(1, "Hans");
            string result1 = u1.ToString();
            Console.WriteLine(result1);


            User2 u2 = new User2(2, "杨先生");
            string result2 = u2.ToString();
            Console.WriteLine(result2);
            u2.SayHi();

            int result3 = u2.Add(1, 2);
            Console.WriteLine(result3);
            Console.ReadLine();


            User1 u3 = new User1()     ///这个是对象初始化器。 
                                      //不仅可以给字段 赋值，也可以给属性 赋值
            {
                id = 2,
                name="hans",
            };

            string result4=  u3.ToString();
            Console.WriteLine(result4);
            Console.ReadLine();
        }
    }

    //老写法
    public class User1
    {
        public int id;

        public string name;

        public User1(int _id, string _name)
        {
            id = _id;
            name = _name;
        }

        public User1()
        {

        }

      

        public override string ToString()
        {
            return $"{id},{name}";   //字符串内插
        }
    }

    //新写法  Lambda 作函数体
    public class User2
    {
        public int id;
        public string name;

        public User2(int _id, string _name)
        {
            id = _id;
            name = _name;
        }

        public override string ToString() => $"{id},{name}";
        public void SayHi() => Console.WriteLine("hello");
        public int Add(int a, int b) => a + b;

    }

}
