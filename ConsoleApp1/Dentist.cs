using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
 {
	public class Dentist : Doctor
    {
        public Dentist(String name) : base(name)
        {

        }
        override public void Treat()
        {
            Console.WriteLine("Dentist treats " + name);
        }
    }
}
