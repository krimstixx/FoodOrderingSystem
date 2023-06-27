using System.ComponentModel.DataAnnotations;

namespace FoodOrderingSystem.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}