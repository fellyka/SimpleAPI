
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace simpleAPI.DataTransferObject
{
    public class SimpleAPICreateDTO
    {   
       // public int Id { get; set; } - No need to supply Id since the database is taking care of that
        [Required]
        public string Name{get;set;}

        [Required]

        public string JobTitle{get;set;}

        [Required]

        public int YearJoined{get;set;}

         [Column(TypeName = "decimal(8,2)")]
        public decimal Salary{get;set;}
    
    }
}