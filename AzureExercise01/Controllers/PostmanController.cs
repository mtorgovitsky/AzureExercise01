using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace AzureExercise01.Controllers
{
    public class PostmanController : ApiController
    {
        // GET: Postman
        [HttpGet]
        public IEnumerable<Address> Get()
        {
            var model = new Model1();
            var addresses = model
                .Addresses
                .Where(a => a.City.Contains("a"))
                .ToList();
            return addresses;
        }

        [HttpPost]
        public string Post([FromBody]string sGet)
        {
            return $"The input value is: { sGet}";
        }
    }
}