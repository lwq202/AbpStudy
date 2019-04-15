using System.ComponentModel.DataAnnotations;

namespace Study.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}