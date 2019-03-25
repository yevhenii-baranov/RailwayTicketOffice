using System.ComponentModel.DataAnnotations;

namespace RailwayTicketOffice.Models
{
    public class UserRegisterModel
    {
        [Required(ErrorMessage = "Please enter valid Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Please enter password once again")]
        [DataType(DataType.Password)]
        public string PasswordConfirmation { get; set; }
    }
}