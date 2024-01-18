using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bookkeeper : Administration
    {
        public String salary;
        public Bookkeeper(String name, String salary) : base(name)
        {
            this.salary = salary;
        }

        override public void Manage()
        {
            Console.WriteLine("Bookkeeper accrues" + name + " " + salary);
        }

    }
}