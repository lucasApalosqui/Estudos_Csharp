using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda.Entities
{
    internal class Category : Identity
    {
        public int tier { get; set; }

        public Category(int id, string name, int tier) : base(id, name)
        {
            this.tier = tier;
        }
    }
}
