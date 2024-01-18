using System;
using System.Numerics;

namespace ConsoleApp1
{

    class Program
    {
        static void Main()
        {
            Surgeon sur = new Surgeon("Sam", "head");
            Doctor doc = new Surgeon("Glen", "neck");
            Dentist den = new Dentist("Jorro");
            Dentist den2 = new Dentist("Mike");
            Therapist ther = new Therapist("Lidy");
            Ent en = new Ent("John", "auricle");
            Ophthalmologist oph = new Ophthalmologist("Robert", "pupil");
            List<Doctor> doctors = new List<Doctor>();
            doctors.Add(sur);
            doctors.Add(doc);
            doctors.Add(den);
            doctors.Add(den2);
            doctors.Add(ther);
            doctors.Add(en);
            doctors.Add(oph);
            /*foreach (Doctor doctor in doctors)
            {
                doctor.Treat();
            }*/
            ChiefMedician Polly = new ChiefMedician("polly", "fired");
            Bookkeeper Sara = new Bookkeeper("Sara", "salary");

            List<Administration> administrations = new List<Administration>();
            administrations.Add(Polly);
            administrations.Add(Sara);
/*            foreach (Administration administration in administrations)
            {
                administration.Manage();
            }*/

/*            List<IWorkable> workables = new List<IWorkable>()
            {
                sur, den,ther, en, oph, Polly, Sara
            };
            foreach (var workable in workables)
            {
                workable.Work();
            }*/
            List<IWRable> wRables = new List<IWRable>() //одна коллекция на объединенный интерфейс.
            {
                sur, den,ther, en, oph, Polly, Sara
            };
            foreach (var wRable in wRables)
            {
                wRable.Work();
                wRable.Rest();
            }
            Console.ReadLine();

        }
    }
}
