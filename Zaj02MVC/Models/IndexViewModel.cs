using System.Collections.Generic;
using Zaj02MVC.Infrastructure;

namespace Zaj02MVC.Models
{
    public class IndexViewModel
    {
        public Formularz Formularz { get; set; }
        public List<IndexListModel> IndexList { get; set; }
    }

    public class IndexListModel
    {
        public string AuthorName { get; set; }
        public string AuthorLastName { get; set; }
        public string SubAuthorName { get; set; }
        public string SubAutorLastName { get; set; }
        public string DefenderName { get; set; }
        public string DefenderLastName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
    }
}