using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayTicketOffice.Entity
{
    [Table("user")]
    public class User : Entity
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string PassportData { get; set; }

        [DataType(DataType.EmailAddress)] 
        public string Email { get; set; }

        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        public Role UserRole { get; set; }

        public enum Role: int
        {
            USER=0,
            ADMINISTRATOR=1
        }
    }
}