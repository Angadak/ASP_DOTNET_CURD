using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MagicVilla.Models.DTO
{
    public class DTOClass
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public string?  Description { get; set; }
        public int Rate { get; set; }
        [Required]
        public int sqrt { get; set; }
        public int Occupancy { get; set; }
        public string? image { get; set; }
        public string? Aminety { get; set; }
        public string? AcessToken { get;  set; }
    }
}
