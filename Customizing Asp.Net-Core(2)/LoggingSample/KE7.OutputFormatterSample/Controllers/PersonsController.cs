using KE7.OutputFormatterSample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenFu;



namespace KE7.OutputFormatterSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<Person>> Get()
        {
            var persons = A.ListOf<Person>(50);
            return persons;
        }



    }
}
