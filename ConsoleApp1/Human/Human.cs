﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Human:IWRable
    {
        public string name;
        public int age;
        public abstract void Work();
        public virtual void Rest()
        {

        }
        public abstract void OnFire();
    }
    
}