using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeedemo
{ 
    internal class Employee
    {
        private int id;
        private string name;
        double salary;

        public void add(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public string Print()
        {
            return $" Employee:{id}/{name}/{salary}";
        }
    } 
}     
