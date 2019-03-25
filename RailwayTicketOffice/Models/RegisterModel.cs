using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RailwayTicketOffice.Models
{
    public class UserRegisterModel
    {
        [DisplayName("Your Email")]
        [Required(ErrorMessage = "Please enter valid Email:")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [DisplayName("Your password")]
        [Required(ErrorMessage = "Please enter password:")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [DisplayName("Please enter password again:")]
        [Required(ErrorMessage = "Please enter password once again")]
        [DataType(DataType.Password)]
        public string PasswordConfirmation { get; set; }
    }
}