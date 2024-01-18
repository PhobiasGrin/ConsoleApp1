using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ophthalmologist : Doctor
    {
        public string eyes;
        public Ophthalmologist(String name, string eyes) : base(name)
        {
            this.eyes = eyes;
        }
        override public void Treat()
        {
            Console.WriteLine("Ophthalmologist treats " + name + " " + eyes);
        }
    }
}