using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 只读属性初始化
{
    class Program
    {
        static void Main(string[] args)
        {
            User1 u1 = new User1();
            Console.WriteLine(u1.Name);
            Console.ReadLine();
        
        }
    }

    public class User1
    {      
        public string Name { get; } = "hello world";
    }
}
