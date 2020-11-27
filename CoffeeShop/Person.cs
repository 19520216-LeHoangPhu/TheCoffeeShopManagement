﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement
{
    public class Person
    {
        protected ID id;
        protected string name, address, sdt, sex;

        public Person(string id, string name, string address, string sdt, string sex)
        {
            this.id = new ID(id);
            this.name = name;
            this.address = address;
            this.sdt = sdt;
            this.sex = sex;
        }
    }
}