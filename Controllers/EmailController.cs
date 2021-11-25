using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using CarsAPI.Models;
using CarsAPI.DAL;
using CarsAPI.Services;

namespace CarsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private ApplicationContext appContext;
        private IEmailSender emailSender;
        public EmailController(ApplicationContext _appContext, IEmailSender _emailSender)
        {
            this.appContext = _appContext;
            this.emailSender = _emailSender;   
        }

        [HttpPost("{carId}")]
        public IActionResult Post(string carId)
        {
            var token = Request.Headers["token"];
            Customer customer = appContext.Customers.FirstOrDefault(x => x.Token == token);
            Car car = appContext.Cars.FirstOrDefault(x => x.IdentificationNumber == carId);

            if (customer == null || car == null) 
            {
                return BadRequest();
            }

            bool result = emailSender.SendEmail(customer.Email, customer.Name, car.ToString());

            if (result) { 
                return Ok();
            }
            else return StatusCode(503);
        }
    }
}
