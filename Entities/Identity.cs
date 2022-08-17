﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda.Entities
{
    internal class Identity
    {
        public int id { get; set; }
        public string name { get; set; }

        public Identity()
        {

        }
        public Identity(int id, string name)
        {
            this.id = id;
            this.name = name;
            
        }
    }
}
