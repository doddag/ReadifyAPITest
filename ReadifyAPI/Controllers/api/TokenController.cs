using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReadifyAPI.Controllers.api
{
    public class TokenController : ApiController
    {
        [System.Web.Http.HttpGet]
        [System.Web.Http.ActionName("Token")]
        public string Token()
        {
            return "b3c8f310-6d07-41c3-91ba-2ac596783a26";
        }

    }
}

