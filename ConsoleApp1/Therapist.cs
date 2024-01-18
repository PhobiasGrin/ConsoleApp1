using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Therapist : Doctor
    {
        public Therapist(String name) : base(name)
        {

        }
        override public void Treat()
        {
            Console.WriteLine("Therapist treats " + name);
        }

    }
}