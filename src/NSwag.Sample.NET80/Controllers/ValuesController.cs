﻿using Microsoft.AspNetCore.Mvc;

namespace NSwag.Sample.NET80.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public class Person
        {
            public string FirstName { get; set; } = "";

            public string? MiddleName { get; set; }

            public string LastName { get; set; } = "";

            public DateTime DayOfBirth { get; set; }
        }

#pragma warning disable CA1711
        public enum TestEnum
#pragma warning restore CA1711
        {
            Foo,
            Bar
        }

        [HttpGet]
        [ProducesResponseType(204)]
        [ProducesResponseType(200)]
        [ProducesResponseType(201)]
        public ActionResult<IEnumerable<Person>> Get()
        {
            return Array.Empty<Person>();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<TestEnum> Get(int id)
        {
            return TestEnum.Foo;
        }

        // GET api/values/ToString(5)
        [HttpGet("ToString({id})")]
        public ActionResult<string> GetToString(int id)
        {
            return TestEnum.Foo.ToString();
        }

        // GET api/values/id:5
        [HttpGet("id:{id}")]
        public ActionResult<string> GetToId(int id)
        {
            return TestEnum.Foo.ToString();
        }

        // GET api/values/5
        [HttpGet("{id}/foo")]
        public ActionResult<string> GetFooBar(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
