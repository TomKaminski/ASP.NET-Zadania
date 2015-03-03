using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkExample.Identity
{
    public class Student
    {
        public Student()
        {
            Phones = new List<Phone>();
        }

        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NrIndeksu { get; set; }

        [Column("Imie"),Display(Name="Imie")]
        public string Name { get; set; }

        [Column("Nazwisko"), Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }
    }

    [Table("Adres")]
    public class Address
    {
        [Key, ForeignKey("Student"), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NrIndeksu { get; set; }

        //[Column("Ulica")] - Check Fluent API
        public string Street { get; set; }

        [Column("Numer domu")]
        public string Number { get; set; }

        [Column("Kod pocztowy")]
        public string PostalCode { get; set; }

        public virtual Student Student { get; set; }
    }

    [Table("Telefon")]
    public class Phone
    {
        [Key]
        public int PhoneId { get; set; }

        [ForeignKey("Student")]
        public int NrIndeksu { get; set; }

        public int Number { get; set; }

        [Column("Operator")]
        public string OperatorName { get; set; }

        [Column("Komórka")]
        public bool IsMobile { get; set; }

        public virtual Student Student { get; set; }
    }
}