using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract public class Administration: Employee
    {
 /*       public String name;*/
        public Administration(String name)
        {
            this.name = name;
        }
        abstract public void Manage();
        public override void Work()
        {
            this.Manage();
        }
        public override void Rest()
        {
            Console.WriteLine("Resting");
        }
    }
}