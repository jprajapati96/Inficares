using Inficare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inficare
{
    public class StaticData
    {
        public static List<BankViewModel> BankData()
        {
            List<BankViewModel> banks = new List<BankViewModel>();
            banks.Add(new BankViewModel{Name = "NIC Asia Bank Ltd.", Contact="9857463523" });
            banks.Add(new BankViewModel { Name = "Prabhu Bank Ltd.", Contact = "9847462722" });
            return banks;
        }
        public static List<CustomerViewModel> CustomerData()
        {
            List<CustomerViewModel> customers = new List<CustomerViewModel>();
            customers.Add(new CustomerViewModel { Name = "Rabi Teza", Email = "rabi@nic.com.np" });
            customers.Add(new CustomerViewModel { Name = "Stone Cold", Email = "stone@prabhu.com.np",Password="string" });
            return customers;
        }
    }
}
