using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TesteApi.Controllers
{
    public class HomeController : ApiController
    {

        public object Get()
        {
            return new {id=1,nome="teste", login="teste2" };
        }

    }
}
