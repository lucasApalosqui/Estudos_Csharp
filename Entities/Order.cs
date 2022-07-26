using System;
using ProjetoIntermediario.Entities.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntermediario.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return 
                "ID: " + Id
                + " / "
                + "DATA: " + Moment
                + " / " 
                + "STATUS: " + Status;
        }
    }
}
