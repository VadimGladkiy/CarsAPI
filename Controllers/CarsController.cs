using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using CarsAPI.Models;
using CarsAPI.DAL;


namespace CarsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private ApplicationContext appContext;
        public CarsController(ApplicationContext _appContext)
        {
            this.appContext = _appContext;
        }

        // GET api/cars/2
        [HttpGet("{page?}")]
        public ActionResult<IEnumerable<Car>> Get(int page = 1)
        {
            return appContext.Cars.OrderBy(x => x.IdentificationNumber).Skip((page -1) * 5).Take(5).ToList();
        }

        // POST api/cars
        [HttpPost]
        public ActionResult<Car> Post(Car car)
        {
            if (car == null)
            {
                return BadRequest();
            }

            Car alreadyExists = appContext.Cars.FirstOrDefault(x => x.IdentificationNumber == car.IdentificationNumber);
            
            if (alreadyExists == null)
            {
                appContext.Cars.Add(car);
                appContext.SaveChanges();

                return Ok(car);
            }
            else 
            {
                return BadRequest();
            }
        }

        // PUT api/cars/
        [HttpPut]
        public ActionResult<Car> Put(Car car)
        {
            if (car == null)
            {
                return BadRequest();
            }
            if (!appContext.Cars.Any(x => x.IdentificationNumber == car.IdentificationNumber))
            {
                return NotFound();
            }

            appContext.Update(car);
            appContext.SaveChanges();
            return Ok(car);
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public ActionResult<Car> Delete(string id)
        {
            Car car = appContext.Cars.FirstOrDefault(x => x.IdentificationNumber == id);
            
            if (car == null)
            {
                return NotFound();
            }

            appContext.Cars.Remove(car);
            appContext.SaveChanges();
            return Ok(car);
        }
    }
}
