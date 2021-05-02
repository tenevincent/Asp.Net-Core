using KE8.ModelBinderSample.Binders;
using KE8.ModelBinderSample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KE8.ModelBinderSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        [HttpPost]
        public ActionResult<object> Post([ModelBinder(binderType: typeof(PersonsCsvBinder))]  
        IEnumerable<Person> persons)
        {
            return new
            {
                ItemsRead = persons.Count(),
                Persons = persons
            };
        }



    }
}
