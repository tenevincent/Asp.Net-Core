using GenFu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace KEB10.TagHelperSample.Services
{
    public interface IService
    {
        IEnumerable<Person> AllPersons();
    }
    internal class PersonService : IService
    {
        public IEnumerable<Person> AllPersons()
        {
            return A.ListOf<Person>(250);
        }
    }
    public class Person
    {
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        public string LastName { get; set; }

        public int Age { get; set; }

        [DisplayName("Email address")]
        public string EmailAddress { get; set; }
    }
}
