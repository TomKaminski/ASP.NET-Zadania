using System.ComponentModel.DataAnnotations;

namespace Zaj02.Infrastructure
{
    public class Formularz
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane"), Display(Name = "Imię")]
        [RegularExpression("[A-Ża-ż]*", ErrorMessage = "Pole {0} jest niepoprawne")]
        public string AuthorName { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane"), Display(Name = "Nazwisko")]
        [RegularExpression("[A-Ża-ż]*", ErrorMessage = "Pole {0} jest niepoprawne")]
        public string AuthorLastName { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane"),
         EmailAddress(ErrorMessage = "Podaj poprawny adres email"), Display(Name = "Email")]
        public string AuthorEmail { get; set; }

        [Display(Name = "Imię")]
        [RegularExpression("[A-Ża-ż]*", ErrorMessage = "Pole {0} jest niepoprawne")]
        public string SubAuthorName { get; set; }

        [Display(Name = "Nazwisko")]
        [RegularExpression("[A-Ża-ż]*", ErrorMessage = "Pole {0} jest niepoprawne")]
        public string SubAuthorLastName { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane"), Display(Name = "Imię")]
        [RegularExpression("[A-Ża-ż]*", ErrorMessage = "Pole {0} jest niepoprawne")]
        public string DefenderName { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane"), Display(Name = "Nazwisko")]
        [RegularExpression("[A-Ża-ż]*", ErrorMessage = "Pole {0} jest niepoprawne")]
        public string DefenderLastName { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane"), Display(Name = "Nazwa")]
        public string UniversityName { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane"), Display(Name = "Adres")]
        public string UniversityAddress { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane"), Display(Name = "Tytuł")]
        public string ReportTitle { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane")]
        public string ReportSummary { get; set; }
    }

    public class FormularzPlz
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorEmail { get; set; }
        public string SubAuthorName { get; set; }
        public string SubAuthorLastName { get; set; }
        public string DefenderName { get; set; }
        public string DefenderLastName { get; set; }
        public string UniversityName { get; set; }
        public string UniversityAddress { get; set; }
        public string ReportTitle { get; set; }
        public string ReportSummary { get; set; }
    }
}