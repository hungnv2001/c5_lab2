using System.ComponentModel.DataAnnotations.Schema;

namespace lab1.Models
{
    
    public class Client
    {
        public string clientName { get; set; }
        public int AddressID { get; set; }
        public string PhoName { get; set; }
        public Address Address { get; set;}
    }
}
