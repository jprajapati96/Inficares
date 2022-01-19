using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  Inficare;
using Inficare.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Inficare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        // GET: api/<BankController>
        [HttpGet("GetBankList")]
        public IEnumerable<BankViewModel> GetBankList()
        {

            var banks = StaticData.BankData();
            return banks;
        }


        // POST api/<BankController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

    }
}
