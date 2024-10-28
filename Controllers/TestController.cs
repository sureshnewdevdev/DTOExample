using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DTOExample.Controllers
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("StringInput")]
        public string GetString(string name)
        {
            return " I am string";
        }

        [HttpGet("NumberInput")]
        public string GetNumber(int number)
        {
            return " I am Number";
        }

        [HttpPost("CustomType")]
        public Person GetCustomType(Person person)
        {
            return  person;
        }
    }
}
