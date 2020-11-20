using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using simpleAPI.DataRepository;
using simpleAPI.DataTransferObject;
using simpleAPI.Models;

namespace simpleAPI.Controllers
{
    //This class inherits from the ControllerBase, i.e: There will be no views 

    
    [Route("api/simpleapi")]
    [ApiController]
    public class SimpleAPIController : ControllerBase
    {
      private readonly ISimpleAPIRepo repo;
      private readonly IMapper mapper;

        public SimpleAPIController(ISimpleAPIRepo repo, IMapper mapper)
      {
          this.repo = repo;
          this.mapper = mapper;
      }
        //GET api/SimpleAPI
        [HttpGet]
        public ActionResult <IEnumerable<SimpleAPIReadDTO>> GetAllInfo()
        {
            var apiData = repo.getAllData();
            return Ok(mapper.Map<IEnumerable<SimpleAPIReadDTO>>(apiData));
        }

        //GET api/SimpleAPI/{id}
        [HttpGet("{id}",Name="getInfoById")]
        public ActionResult<SimpleAPIReadDTO> getInfoById(int id)
        {
            var apiData = repo.getDataById(id);
            if (apiData == null)
                return NotFound();
            else
                return Ok(mapper.Map<SimpleAPIReadDTO>(apiData));
        }

       //POST api/SimpleAPI
       [HttpPost]
       public ActionResult<SimpleAPICreateDTO> PostData(SimpleAPICreateDTO apiData)
       {
           var dataApi = mapper.Map<SimpleAPI>(apiData);
           repo.CreateData(dataApi);
           repo.SaveChanges(); //writes changes to the db

           var apiDtoRead = mapper.Map<SimpleAPIReadDTO>(dataApi);

          return CreatedAtRoute(nameof(getInfoById), new {Id = apiDtoRead.Id}, apiDtoRead);   
       }

       //PUT api/SimpleAPI/{id}
       [HttpPut]
       public ActionResult UpdateCommand(int id, SimpleAPIUpdateDTO apiData)
       {
           var data = repo.getDataById(id);
           if (data == null)
              return NotFound();

           else
            {
                mapper.Map(apiData, data);
                repo.UpdateSimpleApi(data);
                repo.SaveChanges();

                return NoContent();
            }
       }


      
    }
}