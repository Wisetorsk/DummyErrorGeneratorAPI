using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErrorGenerator.DummyError;
using Microsoft.AspNetCore.Cors;

namespace ErrorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Error : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            string err = ErrorStrings.FullError();
            return err;
        }

        [HttpGet("{number}")]
        public string[] Get(int number)
        {
            string[] errors = new string[number];
            for (int errorNumber = 0; errorNumber < number; errorNumber++)
            {
                errors[errorNumber] = ErrorStrings.FullError();
            }
            return errors;
        }

    }
}
