using System.Collections.Generic;
using System.Web.Http;
using WebApi2.Models;

namespace WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        public IProductRepository ProductRepository { get; }

        public ValuesController(IProductRepository productRepository)
        {
            ProductRepository = productRepository;
        }
        /// <summary>
        /// Gets the values
        /// </summary>
        /// <returns></returns>
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }
        /// <summary>
        /// Post new input datas
        /// </summary>
        /// <param name="InputData"></param>
        /// <returns></returns>
        // POST api/values
        public IHttpActionResult Post([FromBody]InputData InputData)
        {
            return Ok(InputData);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
