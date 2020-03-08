using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8,MinimumLength  =4,ErrorMessage = "izmedju 4 i 8 slova mora biti sifra")]
        public string Password { get; set; }
    }
}