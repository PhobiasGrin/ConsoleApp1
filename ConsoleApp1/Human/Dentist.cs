using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Doctors
{
    public class Dentist : Doctor
    {
        public Dentist(string name, DoctorType doctorType) : base(name, doctorType)
        {
        }
        override public void Treat()
        {
            Console.WriteLine("Dentist treats " + name);
        }
        public override void Rest()
        {
            Console.WriteLine("Dentist walks on Paris");
        }
    }
}
