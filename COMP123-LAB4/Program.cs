using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_LAB4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person arsh = new Person(name: "Arshdeep Singh", age: 20);

            arsh.SaysHello();

            Console.ReadLine();
        }
    }
}
