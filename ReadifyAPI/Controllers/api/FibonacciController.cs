using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;

namespace ReadifyAPI.Controllers.api
{
    public class FibonacciController : ApiController
    {
        [System.Web.Http.HttpGet]
        [System.Web.Http.ActionName("Fibonacci")]
        public long Fibonacci(long n)
        {
            if (n > 92 || n < -92)
            {
                //will cause a 64 - bit integer overflow.
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var sqrt5 = Math.Sqrt(5);

            var goldenRatio = (sqrt5 + 1) / 2;
            var minigoldenRatio = goldenRatio - 1;

            return Convert.ToInt64((Math.Pow(goldenRatio, n) - Math.Pow(-minigoldenRatio, n)) / sqrt5);
        }
    }
}
