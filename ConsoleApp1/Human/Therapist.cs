using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Doctors
{
    public class Therapist : Doctor
    {
        public Therapist(string name, DoctorType doctorType) : base(name, doctorType)
        {

        }
        override public void Treat()
        {
            Console.WriteLine("Therapist treats " + name);
        }

    }
}