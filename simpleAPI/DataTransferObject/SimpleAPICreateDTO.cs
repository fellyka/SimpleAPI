

namespace simpleAPI.DataTransferObject
{
    public class SimpleAPICreateDTO
    {   
       // public int Id { get; set; } - No need to supply Id since the database is taking care of that
        public string Name{get;set;}
        public string JobTitle{get;set;}
        public int YearJoined{get;set;}
        public decimal Salary{get;set;}
    
    }
}