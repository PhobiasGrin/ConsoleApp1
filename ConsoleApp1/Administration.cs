using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract public class Administration 
    {
        public String name;
        public Administration(String name)
        {
            this.name = name;
        }
        abstract public void Manage();
    }
}