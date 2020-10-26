namespace simpleAPI.DataTransferObject
{
    public class SimpleAPIReadDTO
    {
        public int Id { get; set; }
        public string Name{get;set;}
        public string JobTitle{get;set;}
        public int YearJoined{get;set;}

        //We don't want folks salaries to be pulled ; that's the 
        //reason this class looks slightly different to the SimpleAPI class
    }
}