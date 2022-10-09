using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeedemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.add(93, "Ashwin", 75.7);
            Console.WriteLine(e1.Print());  
        }
    }
}
