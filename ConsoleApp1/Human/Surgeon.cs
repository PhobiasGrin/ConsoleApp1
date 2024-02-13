using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Doctors
{
    public class Surgeon : Doctor
    {
        public string bodyPart;
        public Surgeon(string name, string bodyPart, DoctorType doctorType) : base(name, doctorType)
        {
            this.bodyPart = bodyPart;
        }
        override public void Treat()
        {
            Console.WriteLine("Surgeon treats " + name + " " + bodyPart);
        }
    }
}