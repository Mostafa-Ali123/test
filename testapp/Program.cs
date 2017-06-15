using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p = new Person();
            p.Id = 1;
            p.Name = "A";
            Console.WriteLine("My name is {0}",p.Name);
        }
    }
}
