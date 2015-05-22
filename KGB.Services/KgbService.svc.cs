using System;
using System.Collections.Generic;
using Inovix.Data.Contracts;
using KGB.Services.Interfaces;

namespace KGB.Services
{
    public class KgbService : IKgbService
    {

        public Customer GetCustomerByCpf(string cpf)
        {

            var random = new Random();

            return new Customer()
            {
                Document = cpf,
                Name = "Bill Gates",
                BornDate = DateTime.Now.AddYears(random.Next(-20, -30)).AddMonths(random.Next(1, 10)),
                Email = "bill.gates@microsoft.com"
            };

        }

        public CustomerFinance GetCustomerFinanceByCpf(string cpf)
        {

            var random = new Random();

            return new CustomerFinance()
            {
                Active = true,
                Invoices = new List<Invoice>
                {
                    new Invoice()
                    {
                        Amount = random.Next(80,100),
                        Month = 1,
                        Year = 2015,
                        PaymentDate = new DateTime(2015, 1, 10)
                    },
                    new Invoice()
                    {
                        Amount = random.Next(80,100),
                        Month = 2,
                        Year = 2015,
                        PaymentDate = new DateTime(2015, 2, 11)
                    },
                    new Invoice()
                    {
                        Amount = random.Next(80,100),
                        Month = 3,
                        Year = 2015,
                        PaymentDate = new DateTime(2015, 3, 10)
                    }
                }
            };

        }

        public Account GetAccount(Customer customer)
        {

            return new Account()
            {
                CreatedDate = DateTime.Now.AddMonths(-4),
                Id = Guid.NewGuid().ToString(),
                PlanName = "Fala Muito 1000"
            };

        }
    }
}
