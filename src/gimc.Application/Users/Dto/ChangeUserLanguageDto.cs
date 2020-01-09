using System.ComponentModel.DataAnnotations;

namespace gimc.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}