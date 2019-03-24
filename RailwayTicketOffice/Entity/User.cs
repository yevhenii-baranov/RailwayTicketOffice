using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayTicketOffice.Entity
{
    [Table("user")]
    public class User : Entity
    {
        [Required] public string FirstName { get; set; }

        [Required] public string LastName { get; set; }

        public string PassportData { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public Role UserRole { get; set; }

        public enum Role: int
        {
            USER=0,
            ADMINISTRATOR=1
        }
    }
}