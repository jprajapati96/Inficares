using Inficare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inficare.Repository
{
    public interface ICustomerRepository
    {
        string VerifyCustomer(CustomerViewModel costomer);
        Response<List<CustomerViewModel>> GetCustomerList();
        Response<CustomerViewModel> AuthenticateCustomer(CustomerViewModel customer);

    }
}
