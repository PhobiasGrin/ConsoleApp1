using ConsoleApp1.Doctors;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static event Action Fire;
        static void Main(string[] args)
        {

            Surgeon sur = new Surgeon("Sam", "head", DoctorType.Surgeon);
            Doctor doc = new Surgeon("Glen", "neck", DoctorType.Surgeon);
            Dentist den = new Dentist("Jorro", DoctorType.Dentist);
            Dentist den2 = new Dentist("Mike", DoctorType.Dentist);
            Therapist ther = new Therapist("Lidy", DoctorType.Therapist);
            Ent en = new Ent("John", "auricle", DoctorType.Ent);
            Ophthalmologist oph = new Ophthalmologist("Robert", "pupil", DoctorType.Ophthalmologist);
            Vitamin Vita = new Vitamin("Retinol", "Stomack");
            Vitamin Vitb = new Vitamin("Tiamin", "Head");
            Vitamin Vitc = new Vitamin("Ascorbin", "Back");
            Vitamin Vitd = new Vitamin("Holycalciferol", "Mind");
            //Antibiotic Lev = new Antibiotic("Penicillin", "Infection");
            //Antibiotic Tetr = new Antibiotic("Cephalosporins", "Bacterial");
            //Antibiotic Linc = new Antibiotic("Tetracycline", "Acne");
            Hormone Trip = new("Triptamin", "Mood");
            Hormone Pep = new Hormone("Peptide", "CNS");
            Hormone Ster = new Hormone("Sterin", "Mushroom");

            List<Doctor> doctors = new List<Doctor>();
            doctors.Add(sur);
            doctors.Add(doc);
            doctors.Add(den);
            doctors.Add(den2);
            doctors.Add(ther);
            doctors.Add(en);
            doctors.Add(oph);

            ChiefMedician Polly = new ChiefMedician("polly", "fired");
            Bookkeeper Sara = new Bookkeeper("Sara", "salary");

            List<Administration> administrations = new List<Administration>();
            administrations.Add(Polly);
            administrations.Add(Sara);

            List<IWRable> wRables = new List<IWRable>() //одна коллекция на объединенный интерфейс.
            {
                sur, den,ther, en, oph, Polly, Sara
            };
            foreach (var wRable in wRables)
            {
                wRable.Work();
                wRable.Rest();
            }
            List<Medicine> medicines = new List<Medicine>();
            medicines.Add(Vita);
            medicines.Add(Vitb);
            medicines.Add(Vitc);
            medicines.Add(Vitd);
            //medicines.Add(Lev);
            //medicines.Add(Tetr);
            //medicines.Add(Linc);
            medicines.Add(Trip);
            medicines.Add(Pep);
            medicines.Add(Ster);

            List<Antibiotic> antibiotics = new List<Antibiotic>();
            antibiotics.Add(new Antibiotic("Penicilin", AntibioticType.Infection));
            antibiotics.Add(new Antibiotic("Cephalosporins", AntibioticType.Bacterial));
            antibiotics.Add(new Antibiotic("Tetracycline", AntibioticType.Acne));

            List<ICurable> curables = new List<ICurable>();
            curables.AddRange((IEnumerable<ICurable>)medicines);
            //curables.AddRange(doctors);

            List<ICurable> wCurables = new List<ICurable>()
            {
                // Vita, Vitb, Vitc, Vitd,Trip, Pep, Ster //Lev, Tetr, Linc,
            };
            foreach (var wCurable in wCurables)
            {
                wCurable.Assign();
                wCurable.Receive();
            }
            Dictionary<DoctorType, List<Medicine>> cureMedicines = new Dictionary<DoctorType, List<Medicine>>(); //словарь: добавить пару, или обратиться по ключу и добавить к ключу значение
            cureMedicines.Add(DoctorType.Dentist, new List<Medicine>(antibiotics));
            cureMedicines.Add(DoctorType.Surgeon, new List<Medicine>(antibiotics));
            cureMedicines[DoctorType.Surgeon].AddRange(medicines.Where(x => x is Vitamin));
            cureMedicines.Add(DoctorType.Ent, medicines.Where(x => x is Vitamin).ToList());
            cureMedicines.Add(DoctorType.Therapist, medicines.Where(x => x is Hormone).Where(x => ((Hormone)(x)).types.Equals("CNS")).ToList());
            cureMedicines[DoctorType.Ophthalmologist] = new List<Medicine>(antibiotics);


            // имя препаратов, доступных дантисту
            var dentistMedicineNames = cureMedicines.Where(x => x.Key.Equals(DoctorType.Dentist)).FirstOrDefault().Value.Select(x => x.name);
            foreach (var name in dentistMedicineNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(cureMedicines.Where(x => x.Key.Equals(DoctorType.Dentist)).FirstOrDefault().Value.Select(x => x.name));
            Console.ReadLine();


            void TurnOnFireAlarm(List<Human> humans)
            {
                Console.WriteLine("Fire Alert");

                foreach (Human humans in human)
                {
                    Fire += humans.OnFire;
                }

                Action onFire = humans.OnFire;

                TurnOnFireAlarm(Human);
            }
    }
}


