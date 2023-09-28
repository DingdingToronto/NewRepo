using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1_Jiabao_Ding_n10635074.Controllers
{
    public class SquareController : ApiController
    {
        public int Get(int id)
        {
            return id * id;
        }
    }
}
