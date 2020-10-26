using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace simpleAPI.Models
{
    public class SimpleAPI
    {
        
        public int Id { get; set; }
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