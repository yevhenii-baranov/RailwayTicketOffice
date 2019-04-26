using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayTicketOffice.Entity
{
    [Table("user")]
    public class User : Entity
    {
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        public string LastName { get; set; }

        [DisplayName("Passport data")]
        public string PassportData { get; set; }

        [DataType(DataType.EmailAddress)] 
        [DisplayName("E-mail")]
        public string Email { get; set; }
        
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [DisplayName("Role")]
        public Role UserRole { get; set; }

        public enum Role: int
        {
            USER=0,
            ADMINISTRATOR=1
        }
    }
}