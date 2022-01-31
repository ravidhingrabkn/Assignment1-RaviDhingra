using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_RaviDhingra.Controllers
{
    public class ExampleController : ApiController
    {
        public string Get(int id)
        {
            string greeting = "Greetings to "+ id + " people!";
            return greeting;
        }
    }
}
