using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Doctors
{
    public enum DoctorType { Surgeon, Ent, Therapist, Dentist, Ophthalmologist }
    abstract public class Doctor : Human
    {
        public DoctorType doctorType;
        public Doctor(string name, DoctorType doctortype)
        {
            this.name = name;
            this.doctorType = doctortype;
        }
        abstract public void Treat();
        public override void Work()
        {
            Treat();
        }
        public override void Rest()
        {
            Console.WriteLine("Resting");
        }
    }
}