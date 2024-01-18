using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ent : Doctor
    {
        public string ears;
        public Ent(String name, string ears) : base(name)
        {
            this.ears = ears;
        }
        override public void Treat()
        {
            Console.WriteLine("Ent treats " + name + " " + ears);
        }
    }
}