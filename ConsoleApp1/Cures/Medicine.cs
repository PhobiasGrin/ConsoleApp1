using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Medicine : Treatment
    {
        public Medicine(String name)
        {
            this.name = name;
        }
        abstract public void Accept();
        public override void Receive()
        {
            this.Accept();
        }
        public override void Assign()
        {
            Console.WriteLine("Receiving the medicine");
        }
    }
}
