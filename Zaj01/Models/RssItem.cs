using System.ComponentModel.DataAnnotations;

namespace Zaj01.Models
{
    public class RssItem
    {
        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [UIHint("HTML")]
        public string Description { get; set; }
    }
}