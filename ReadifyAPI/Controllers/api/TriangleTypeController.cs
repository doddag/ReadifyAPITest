using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReadifyAPI.Controllers.api
{
    public class TriangleTypeController : ApiController
    {
        // Get /api/Readify/1/2/3
        [System.Web.Http.HttpGet]
        [System.Web.Http.ActionName("TriangleType")]
        public string TriangleType(int a, int b, int c)
        {
            List<int> sides = new List<int> {a, b, c};

            if (sides.Count(s => s < 1) != 0)
                return "Error";

            int count = sides.GroupBy(s => s).Count();
            if (count == 1)
            {
                return "Equilateral";
            }
            else if (count == 2)
            {
                return "Isosceles";
            }
            else if (count == 3)
            {
                return "Scalene";
            }

            return "Unknown";
        }
    }
}
