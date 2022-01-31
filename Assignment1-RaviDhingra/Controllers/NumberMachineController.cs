using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_RaviDhingra.Controllers
{
    public class NumberMachineController : ApiController
    {
        public int Get(int id)
        {
            int value = (id * id) + (id * id) - id / 100;
            return value;
        }
    }
}
