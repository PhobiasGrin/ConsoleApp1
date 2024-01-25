using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract public class Doctor : Employee
    {
        public Doctor(String name)
        {
            this.name = name;
        }
        abstract public void Treat();
        public override void Work()
        {
            this.Treat();
        }
        public override void Rest() 
        { 
            Console.WriteLine("Resting"); 
        }
    }
}