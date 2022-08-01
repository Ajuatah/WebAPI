using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public string Greet(string name)
        {
            return $"Welcome {name}";
        }
    }
}
