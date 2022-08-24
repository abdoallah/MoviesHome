using System.ComponentModel.DataAnnotations;

namespace MoviesHome.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}