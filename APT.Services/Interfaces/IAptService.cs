using System.ServiceModel;
using Inovix.Data.Contracts;

namespace APT.Services.Interfaces
{
    
    [ServiceContract]
    public interface IAptService
    {

        [OperationContract]
        Portabilidade GetTicketPortabilidade(Customer customer, Account account);

    }

}
