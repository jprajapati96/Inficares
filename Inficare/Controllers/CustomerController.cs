using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inficare.Models;
using Inficare.Repository;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Inficare.Controllers
{   
    
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/<CustomerController>
        private readonly ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }
        [Authorize]
        [HttpGet("GetCustomerList")]
        public IEnumerable<CustomerViewModel> GetCustomerList()
        {
            var customers = StaticData.CustomerData();
            return customers;
        }



        // POST api/<CustomerController>
        [AllowAnonymous]
        [HttpPost("authenticate")]
        
        public IActionResult Authenticate([FromBody] CustomerViewModel customerDetail)
        {
            var response = _customerRepository.VerifyCustomer(customerDetail);
            if (response!=null)
            {
                return Ok(response);
            }
            return Unauthorized();
        }


    }
}
