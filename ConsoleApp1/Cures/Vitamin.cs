using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vitamin : Medicine
    {
        public string types;
        public Vitamin(String name, string types) : base(name)
        {
            this.types = types;
        }
        override public void Accept()
        {
            Console.WriteLine("Vitamin depending on the " + name + " has " + types);
        }
    }
}
