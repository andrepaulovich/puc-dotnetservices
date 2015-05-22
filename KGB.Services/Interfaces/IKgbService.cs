using System.ServiceModel;
using Inovix.Data.Contracts;

namespace KGB.Services.Interfaces
{

    [ServiceContract]
    public interface IKgbService
    {
        
        [OperationContract]
        Customer GetCustomerByCpf(string cpf);

        [OperationContract]
        CustomerFinance GetCustomerFinanceByCpf(string cpf);

        [OperationContract]
        Account GetAccount(Customer customer);

    }

}
