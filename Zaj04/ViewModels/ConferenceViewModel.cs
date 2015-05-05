using System.ComponentModel.DataAnnotations;

namespace Zaj04.ViewModels
{
    public class ConferenceViewModel
    {
        [Required]
        public string AuthorFirstName { get; set; }
        [Required]
        public string AuthorLastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string ArticleTitle { get; set; }
        [Required]
        public string ArticleAbstract { get; set; }
    }
}