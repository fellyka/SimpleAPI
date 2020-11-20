using AutoMapper;
using simpleAPI.DataTransferObject;
using simpleAPI.Models;


namespace simpleAPI.Profiles
{
    public class SimpleAPIProfile : Profile
    {
        public SimpleAPIProfile()
        {
            CreateMap<SimpleAPI,SimpleAPIReadDTO>(); // This maps the SimpleAPI class(Source) to the ReadDTO(Target) --Read from the db
            CreateMap<SimpleAPICreateDTO,SimpleAPI>(); //This maps the CreateDTO(source from API client[Postman/Fiddler...]) to the SimpleAPI --Write to the db
            CreateMap<SimpleAPIUpdateDTO,SimpleAPI>(); //This maps the UpdateDTO(source from API client[Postman/Fiddler...]) to the SimpleAPI --Write to the db
            
            
        }
    }
}