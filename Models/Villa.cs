using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla.Models
{
    public  class Villa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public   int Id  { get; set; }
        [Required]
        [Unicode]
        public  string Name { get; set; }
        public string? Description { get; set; }
        public int Rate { get; set; }
        [Required]
        public int sqrt { get; set; }
        public int Occupancy { get; set; }
        public string? image { get; set; }
        public string? Aminety { get; set; }
        public string? AcessToken { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Uupdated_at { get; set; }
    }
}
