using System.ComponentModel.DataAnnotations;

namespace CommerceApi.Models{
    public class Customer{
        
        [Key]
        public int CutomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}