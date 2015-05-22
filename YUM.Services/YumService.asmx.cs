using System.Web.Services;
using Inovix.Data.Contracts;

namespace YUM.Services
{
    
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class YumService : WebService
    {

        [WebMethod]
        public bool UpdateCustomer(Customer customer)
        {

            if (!string.IsNullOrEmpty(customer.Document))
            {
                return true;
            }

            return false;

        }
    }

}
