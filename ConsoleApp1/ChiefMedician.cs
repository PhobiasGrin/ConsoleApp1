using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ChiefMedician : Administration
    {
        public String decision;
        public ChiefMedician(String name, String decision) : base(name)
        {
            this.decision = decision;
        }

        //override public void Manage()
        override public void Work()
        {
            Console.WriteLine("Chiefmedician manage " + name + " " + decision);
        }

    }
}