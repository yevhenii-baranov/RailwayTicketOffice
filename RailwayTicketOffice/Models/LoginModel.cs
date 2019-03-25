using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RailwayTicketOffice.Models
{
    public class LoginModel
    {
        [DisplayName("Username")]
        [Required(ErrorMessage = "Please enter the correct Email address")]
        public string Email { get; set; }
        
        [DisplayName("Password")]
        [Required(ErrorMessage = "Please enter the password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}