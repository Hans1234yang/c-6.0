using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自动属性初始化
{
    class Program
    {
        static void Main(string[] args)
        {
            User1 u1 = new User1             ///习惯用对象初始化器，这个可以给字段，属性赋值
            {
                name="hans"
            };
         
            u1.Name = "hansss";  //set
            string result = u1.Name;  //get
            Console.WriteLine(result);
            

            User2 u2 = new User2            //习惯用对象初始化器吧，可以给字段，属性赋值
            {
                Name="hans_yang"
            };
            Console.WriteLine(u2.Name);
            Console.ReadLine();
        }
    }

    //老写法
    public class User1
    {
        public string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    public class User2
    {
        public string Name { get; set; }
    }
}
