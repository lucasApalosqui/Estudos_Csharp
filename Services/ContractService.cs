using ExInterfaceContracts.Entities;

namespace ExInterfaceContracts.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;
        public void processContract(Contract contract, int month, IOnlinePaymentService _onlinePaymentService)
        {
            DateTime date;
            for (int i = 1; i <= month; i++)
            {

                date = contract.date.AddMonths(i);
                double amount = _onlinePaymentService.interest(contract.totalValue, month, i);
                Installment instal = new Installment(date, amount);
                contract.installments.Add(instal);


            }
         
        }
    }
}
