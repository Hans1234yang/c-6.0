using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串内插
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "杨先生";
            string address = "深圳人";
            Console.WriteLine($"{name},{address}");
            Console.ReadLine();
        }
    }
}
