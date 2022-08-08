using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExInterfaceContracts.Entities
{
    internal class Contract
    {
        public string number { get; private set; }
        public DateTime date { get; set; }
        public double totalValue { get; private set; }
        public List<Installment> installments = new List<Installment>();

        public Contract(string number, DateTime date, double totalValue)
        {
            this.number = number;
            this.date = date;
            this.totalValue = totalValue;
        }
    }
}
