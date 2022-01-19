using Inficare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inficare.Repository
{
    public interface IBankRepository
    {
        string VerifyBank(CustomerViewModel costomer);
        Response<List<BankViewModel>> GetBankList();
        Response<BankViewModel> AuthenticateBank(BankViewModel bank);
    }
}
