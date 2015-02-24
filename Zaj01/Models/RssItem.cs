using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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