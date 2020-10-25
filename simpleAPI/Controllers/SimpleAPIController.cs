using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using simpleAPI.DataRepository;
using simpleAPI.Models;

namespace simpleAPI.Controllers
{
    //This class inherits from the ControllerBase, i.e: There will be no views 

    
    [Route("api/simpleapi")]
    [ApiController]
    public class SimpleAPIController : ControllerBase
    {
      private readonly ISimpleAPIRepo repo;
      public SimpleAPIController(ISimpleAPIRepo repo)
      {
          this.repo = repo;
      }
        //GET api/SimpleAPI
        [HttpGet]
        public ActionResult <IEnumerable<SimpleAPI>> GetAllInfo()
        {
            var apiData = repo.getAllData();
            return Ok(apiData);
        }

        //GET api/SimpleAPI/{id}
        [HttpGet("{id}")]
        public ActionResult<SimpleAPI> getInfoById(int id)
        {
            var apiData = repo.getDataById(id);
            return Ok(apiData);
        }
    }
}