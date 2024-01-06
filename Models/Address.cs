using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab1.Models
{
    [Table("tblAddress")]
    public class Address
    {
        [Key]

        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Home_addr { get; set; }
        [Required]
        [MaxLength(50)]
        public string Office_addr { get; set; }
        public List<Client> Clients { get; set; }
    }
  
}
