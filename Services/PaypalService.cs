using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExInterfaceContracts.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        public double paymentFee(double amount)
        {
            return amount + (amount * 2) / 100;
        }

        public double interest(double amount, int month, int i)
        {
            amount = amount / month;
            amount = amount + ((amount / 100) * i);
            return paymentFee(amount);

        }
    }
}
