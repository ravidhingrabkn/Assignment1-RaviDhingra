using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_RaviDhingra.Controllers
{
    public class SquareController : ApiController
    {
        // GET api/square
        public int Get(int id)
        {
            return id * id;
        }
    }
}
