using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Doctors
{
    public class Ent : Doctor
    {
        public string ears;
        public Ent(string name, string ears, DoctorType doctorType) : base(name, doctorType)
        {
            this.ears = ears;
        }
        override public void Treat()
        {
            Console.WriteLine("Ent treats " + name + " " + ears);
        }
    }
}