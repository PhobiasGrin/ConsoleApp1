using ConsoleApp1;
using System;
using System.Numerics;

Surgeon sur = new Surgeon("Sam", "head");
Doctor doc = new Surgeon("Glen", "neck");
Dentist den = new Dentist("Jorro");
Dentist den2 = new Dentist("Mike");
Therapist ther = new Therapist("Lidy");
Ent en = new Ent("John", "auricle");
Ophthalmologist oph = new Ophthalmologist("Robert", "pupil");
Vitamin Vita = new Vitamin("Retinol", "Stomack");
Vitamin Vitb = new Vitamin("Tiamin", "Head");
Vitamin Vitc = new Vitamin("Ascorbin", "Back");
Vitamin Vitd = new Vitamin("Holycalciferol", "Mind");
Antibiotic Lev = new Antibiotic("Penicillin", "Infection");
Antibiotic Tetr = new Antibiotic("Cephalosporins", "Bacterial");
Antibiotic Linc = new Antibiotic("Tetracycline", "Acne");
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
medicines.Add(Lev);
medicines.Add(Tetr);
medicines.Add(Linc);
medicines.Add(Trip);
medicines.Add(Pep);
medicines.Add(Ster);

List<IСurable> wCurables = new List<IСurable>()
            {
               Vita, Vitb, Vitc, Vitd,Lev, Tetr, Linc, Trip, Pep, Ster
            };
foreach (var wCurable in wCurables)
{
    wCurable.Assign();
    wCurable.Receive();
}


Console.ReadLine();
