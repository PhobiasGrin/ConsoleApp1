using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Doctor
    {
        public abstract void Treat();
    }
    public class Surgeon : Doctor
    {
        public override void Treat()
        {
            Console.WriteLine("Хирург лечит пациента");
        }
    }
    public class Dentist : Doctor
    {
        public override void Treat()
        {
            Console.WriteLine("Дантист лечит пациента");
        }
    }
    public class Therapist : Doctor
    {
        public override void Treat()
        {
            Console.WriteLine("Терапевт лечит пациента");
        }
    }
    public class TreatmentPlan
    {
        public int Code { get; set; }
    }
    public class Patient
    {
        public Doctor? Doctor { get; set; }
        public TreatmentPlan TreatmentPlan { get; set; }

        public void AssignDoctor()
        {
            switch (TreatmentPlan.Code)
            {
                case 1:
                    Doctor = new Surgeon();
                    break;
                case 2:
                    Doctor = new Dentist();
                    break;
                default:
                    Doctor = new Therapist();
                    break;
            }

            Doctor.Treat();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите код плана лечения:");
            int code = Convert.ToInt32(Console.ReadLine());
            Patient patient = new Patient { TreatmentPlan = new TreatmentPlan { Code = code } };
            patient.AssignDoctor();
        }
    }
}
﻿
