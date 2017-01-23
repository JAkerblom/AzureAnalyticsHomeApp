using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AzureAnalyticsHomeApp.Controllers
{
    [Route("api/[controller]")]
    public class KittensController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<KittenViewModel> Kittens()
        {
            return GetMockKittens();
        }

        public class KittenViewModel
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public decimal Price { get; set; }
            public string Image { get; set; }
            public string Description { get; set; }
        }

        public IEnumerable<KittenViewModel> GetMockKittens()
        {
            var k1 = new KittenViewModel()
            {
                Name = "Thoughtful Little Critter",
                Id = Guid.NewGuid().ToString(),
                Category = "Kitten",
                Price = 5999,
                Description = "",
                Image =
                    "http://static.ddmcdn.com/gif/10-kitten-cuteness-1.jpg"
            };

            var k2 = new KittenViewModel()
            {
                Name = "Scared Little Kittie",
                Id = Guid.NewGuid().ToString(),
                Category = "Kitten",
                Price = 12499,
                Description = "",
                Image =
                    "http://assets.rbl.ms/8325616/980x.jpg"
            };

            var k3 = new KittenViewModel()
            {
                Name = "Curious Little Begger",
                Id = Guid.NewGuid().ToString(),
                Category = "Kitten",
                Price = 10050,
                Description = "You never know when you may need it!",
                Image = "http://cdn.cutestpaw.com/wp-content/uploads/2012/04/l-my-first-kitten.jpg"
            };

            var k4 = new KittenViewModel()
            {
                Name = "Shy Little Kitten",
                Id = Guid.NewGuid().ToString(),
                Category = "Kitten",
                Price = 20,
                Description = "The best thing in the history of ever.",
                Image = "http://www.cutestpaw.com/wp-content/uploads/2016/01/Shy-kitten..jpg"
            };

            var k5 = new KittenViewModel()
            {
                Name = "Cute Gay Little Kitten",
                Id = Guid.NewGuid().ToString(),
                Category = "Kitten",
                Price = 6999,
                Description = "This cute gay leaping kitten will mesmerize you. This cute kitten has mastered the entire lawn that it can leap above all the flowerbeds in the area.",
                Image =
                    "http://www.cutestpaw.com/wp-content/uploads/2016/02/The-big-leap..jpg"
            };

            return new List<KittenViewModel>()
            {
                k1,
                k2,
                k3,
                k4,
                k5,
            };
        }

        //// GET: api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
