using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Surgeon s = new Surgeon("sam", "head");
            Doctor sanya = new Surgeon("sanya", "leg");
            Dentist d = new Dentist("vasya");
            Dentist dd = new Dentist("kolya");
            Therapist t = new Therapist("galya");
            List<Doctor> doctors = new List<Doctor>();
            doctors.Add(s);
            //doctors.Add(irina);
            doctors.Add(sanya);
            doctors.Add(d);
            doctors.Add(dd);
            doctors.Add(t);
            foreach (Doctor doctor in doctors)
            {
                doctor.Treat();
            }
        }
    }
}