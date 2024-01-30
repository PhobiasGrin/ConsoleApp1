using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   public enum AntibioticType { Infection, Bacterial, Acne }
    public class Antibiotic : Medicine
    {
        public AntibioticType antibiotictype;
        public Antibiotic(String name, AntibioticType antibiotictype) : base(name)
        //private AntibioticType antibioticType;
        //private AntibioticType antibiotictype;
            //public class Antibiotic(AntibioticType antibiotictype): base(name)
        {
            //this.types = types;
            this.antibiotictype = antibiotictype;
        }
        override public void Accept()
        {
            Console.WriteLine("Antibiotics depending on the " + name + " has " + antibiotictype);
        }
    }
}
