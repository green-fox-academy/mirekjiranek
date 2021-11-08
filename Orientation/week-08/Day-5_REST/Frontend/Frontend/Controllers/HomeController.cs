using Frontend.Models;
using Frontend.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Frontend.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private LogService LogService { get; }
        public HomeController(LogService service)
        {
            LogService = service;
        }
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }
        [HttpGet("log")]
        public DbLogs Get()
        {
            return LogService.FindAll();
        }
        //// GET: api/<ValuesController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<ValuesController>/5
        [HttpGet("doubling")]
        public IActionResult Doubling([FromQuery] int? input)
        {
            if (input is null)
            {
                return Ok(new { error = "Please provide an input!" });
            }
            LogService.Add(new Log { CreatedAt = DateTime.Now, Endpoint = "/doubling", Data = $"input={input}" });
            return Ok(new { received = input, result = input * 2 });
        }
        [HttpGet("greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name is null && title is null)
            {
                return BadRequest(new { error = "Please provide a name and a title!" });
            }
            else if (name is null)
            {
                return BadRequest(new { error = "Please provide a name!" });
            }
            else if (title is null)
            {
                return BadRequest(new { error = "Please provide a title!" });
            }
            LogService.Add(new Log { CreatedAt = DateTime.Now, Endpoint = "/greeter", Data = $"name={name}, title={title}" });
            return Ok(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
        }
        [HttpGet("appenda/{appendable}")]
        public IActionResult Appenda(string appendable)
        {
            if (appendable is null)
            {
                return NotFound(new { error = "Not found!" });
            }
            LogService.Add(new Log { CreatedAt = DateTime.Now, Endpoint = $"/appenda/{appendable}", Data = $"appendable={appendable}" });
            return Ok(new { appended = $"{appendable}" + "a" });
        }
        [HttpPost("/dountil/{operation}")]
        public IActionResult DoUntil([FromRoute] string operation, [FromBody] Until until)
        {
            if (operation is "sum")
            {
                int sum = 0;
                for (int i = (int)until.until; i > 0; i--)
                {
                    sum += i;
                }
                LogService.Add(new Log
                {
                    CreatedAt = DateTime.Now,
                    Endpoint = $"/dountil/{operation}",
                    Data = $"operation={operation}, until={until.until}"
                });
                return Ok(new { result = sum });
            }
            if (operation is "factor")
            {
                int factor = 1;
                for (int i = (int)until.until; i > 0; i--)
                {
                    factor *= i;
                }
                LogService.Add(new Log
                {
                    CreatedAt = DateTime.Now,
                    Endpoint = $"/dountil/{operation}",
                    Data = $"operation={operation}, until={until.until}"
                });
                return Ok(new { result = factor });
            }
            return Ok(new { error = "Please provide a number!" });


        }
        [HttpPost("/arrays")]
        public IActionResult ArrayHandler([FromBody] Arrays array)
        {
            if (array.what is not null && array.numbers is not null)
            {
                if (array.what is "sum")
                {
                    int sum = 0;
                    for (int i = 0; i < array.numbers.Length; i++)
                    {
                        sum += array.numbers[i];
                    }
                    LogService.Add(new Log
                    {
                        CreatedAt = DateTime.Now,
                        Endpoint = $"/arrays",
                        Data = $"what={array.what}, numbers={String.Join(",", array.numbers)}"
                    });
                    return Ok(new { result = sum });
                }
                if (array.what is "multiply")
                {
                    int multiply = 1;
                    for (int i = 0; i < array.numbers.Length; i++)
                    {
                        multiply *= array.numbers[i];
                    }
                    LogService.Add(new Log
                    {
                        CreatedAt = DateTime.Now,
                        Endpoint = $"/arrays",
                        Data = $"what={array.what}, numbers={String.Join(",", array.numbers)}"
                    });
                    return Ok(new { result = multiply });
                }
                if (array.what is "double")
                {
                    int[] result = new int[array.numbers.Length];
                    for (int i = 0; i < array.numbers.Length; i++)
                    {
                        result[i] = array.numbers[i] * 2;
                    }
                    LogService.Add(new Log
                    {
                        CreatedAt = DateTime.Now,
                        Endpoint = $"/arrays",
                        Data = $"what={array.what}, numbers={String.Join(",", array.numbers)}"
                    });
                    return Ok(new { result = result });
                }
            }
            return Ok("Please provide what to do with the numbers!");
        }
        [HttpPost("/sith")]
        public IActionResult Reverse([FromBody] StringManipulation text)
        {
            StringManipulation stringManipulation = new();
            if (String.IsNullOrEmpty(text.text))
            {
                return NotFound(new { error = "Feed me some text you have to, padawan young you are. Hmmm." });
            }
            if (stringManipulation.isEvenNumberOfWords(text.text))
            {
                return Ok(new { sith_text = stringManipulation.Reverser(text.text) });
            }
            else
            {
                return Ok(text);
            }

        }


        /*// POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
