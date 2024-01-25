﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Treatment: IСurable
    {
        public string name;
        public int age;
        public abstract void Assign();
        public virtual void Receive()
        {

        }
    }

}