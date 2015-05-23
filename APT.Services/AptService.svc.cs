using System;
using APT.Services.Interfaces;
using Inovix.Data.Contracts;

namespace APT.Services
{
    public class AptService : IAptService
    {
        public Portabilidade GetTicketPortabilidade(Customer customer, Account account)
        {

            if (customer != null && !string.IsNullOrEmpty(customer.Document))
            {
                return new Portabilidade()
                {
                    Id = Guid.NewGuid().ToString(),
                    CustomerDocument = customer.Document,
                    New = "TIM",
                    Old = "OI"
                };
            }

            return null;

        }
    }
}
