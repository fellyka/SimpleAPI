using AutoMapper;
using simpleAPI.DataTransferObject;
using simpleAPI.Models;


namespace simpleAPI.Profiles
{
    public class SimpleAPIProfile : Profile
    {
        public SimpleAPIProfile()
        {
            CreateMap<SimpleAPI,SimpleAPIReadDTO>(); // This maps the SimpleAPI class to the ReadDTO
        }
    }
}