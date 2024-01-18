using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Surgeon : Doctor
    {
        public String bodyPart;
        public Surgeon(String name, String bodyPart) : base(name)
        {
            this.bodyPart = bodyPart;
        }

        override public void Treat()
        {
            Console.WriteLine("Surgeon treats " + name + " " + bodyPart);
        }

    }
}