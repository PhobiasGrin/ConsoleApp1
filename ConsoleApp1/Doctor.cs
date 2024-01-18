using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
 {
	abstract public class Doctor
    {
        public String name;
        public Doctor(String name)
        {
            this.name = name;
        }
        //virtual public void Treat()
        //{
        //Console.WriteLine("Doctor treats " + name );
        //}
        abstract public void Treat();
    }
}