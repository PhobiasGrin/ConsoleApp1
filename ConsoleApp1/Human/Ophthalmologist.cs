using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Doctors
{
    public class Ophthalmologist : Doctor
    {
        public string eyes;
        public Ophthalmologist(string name, string eyes, DoctorType doctorType) : base(name, doctorType)
        {
            this.eyes = eyes;
        }
        override public void Treat()
        {
            Console.WriteLine("Ophthalmologist treats " + name + " " + eyes);
        }
    }
}