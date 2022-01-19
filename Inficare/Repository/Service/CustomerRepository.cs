using Inficare.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static Inficare.StaticData;
namespace Inficare.Repository.Service
{
    public class CustomerRepository : ICustomerRepository
    {
        public readonly IConfiguration _configuration;
        public CustomerRepository(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public Response<CustomerViewModel> AuthenticateCustomer(CustomerViewModel customer)
        {
            throw new NotImplementedException();
        }

        public string VerifyCustomer(CustomerViewModel customer)
        {
            var customers = GetCustomerList();
            foreach (var item in customers.Data)
            {
                if (customer.Email == item.Email && customer.Password == item.Password)
                {
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var tokenKey = Encoding.ASCII.GetBytes(_configuration["JwtAuth:Key"]);
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                            new Claim(ClaimTypes.Name,customer.Name)
                        }),
                        Expires = DateTime.UtcNow.AddSeconds(120),
                        SigningCredentials = new SigningCredentials(
                            new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature
                            )
                    };
                    var token = tokenHandler.CreateToken(tokenDescriptor);
                    var tokendata = new JwtSecurityTokenHandler().WriteToken(token);
                    return tokendata;
                }
            }


            return null;
        }

        public Response<List<CustomerViewModel>> GetCustomerList()
        {
            var customers = CustomerData();
            var response = new Response<List<CustomerViewModel>>();
            response.Data = customers;
            response.Code = 200;
            response.Message = "Retrieved Data Successfully";
            return response;
        }
    }
}
