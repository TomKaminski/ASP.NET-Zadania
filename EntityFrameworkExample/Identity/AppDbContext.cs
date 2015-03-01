using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Text;

namespace EntityFrameworkExample.Identity
{
    public class AppDbContext:DbContext
    {
        public AppDbContext():base("AppDbContext")
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            var studentEntityConfig = modelBuilder.Entity<Student>();
            studentEntityConfig.HasKey(x => x.NrIndeksu).Property(x => x.NrIndeksu).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            studentEntityConfig.HasMany(x => x.Phones).WithRequired(x => x.Student).HasForeignKey(a => a.NrIndeksu);
            studentEntityConfig.HasOptional(x => x.Address).WithRequired(x => x.Student);

            var addressEntityConfig = modelBuilder.Entity<Address>();
            addressEntityConfig.Property(x => x.Street).HasColumnName("Ulica");

            var phoneEntityConfig = modelBuilder.Entity<Phone>();
            phoneEntityConfig.HasRequired(x => x.Student).WithMany(x => x.Phones).HasForeignKey(x => x.NrIndeksu);
            phoneEntityConfig.Property(x => x.Number).HasColumnName("Numer telefonu");
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                var newException = new FormattedDbEntityValidationException(e);
                throw newException;
            }
            
        }

        public class AppDbInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
        {
            protected override void Seed(AppDbContext context)
            {
                IList<Student> students = new List<Student>
                {
                    new Student {Name = "Tomasz", LastName = "Kamiński", NrIndeksu = 43574},
                    new Student {Name = "Katarzyna", LastName = "Jasiewicz", NrIndeksu = 43571},
                    new Student {Name = "Andrzej", LastName = "Kastelik", NrIndeksu = 43575},
                    new Student {Name = "Krzysztof", LastName = "Greń", NrIndeksu = 43576},
                };
                foreach (var student in students)
                    context.Students.Add(student);
                
                IList<Address> addresses = new List<Address>
                {
                    new Address {Street = "Maków", Number = "12", NrIndeksu = 43574, PostalCode = "43-200"},
                    new Address {Street = "Partyzantów", Number = "31", NrIndeksu = 43571, PostalCode = "11-111"},
                    new Address {Street = "Andrzej", Number = "Kastelik", NrIndeksu = 43575, PostalCode = "41-300"},
                    new Address {Street = "Kameliowa", Number = "52", NrIndeksu = 43576, PostalCode = "43-300"},
                };
                foreach (var address in addresses)
                    context.Addresses.Add(address);

                IList<Phone> phones = new List<Phone>
                {
                    new Phone {Number = 789252925, OperatorName = "Orange", NrIndeksu = 43574, IsMobile = true},
                    new Phone {Number = 123451513, OperatorName = "Play", NrIndeksu = 43571, IsMobile = false},
                    new Phone {Number = 532231351, OperatorName = "TMobile", NrIndeksu = 43575, IsMobile = true},
                    new Phone {Number = 454323315, OperatorName = "Orange", NrIndeksu = 43576, IsMobile = false},
                };
                foreach (var phone in phones)
                    context.Phones.Add(phone);
                context.SaveChanges();
                base.Seed(context);
            }
        }
        public class FormattedDbEntityValidationException : Exception
        {
            public FormattedDbEntityValidationException(DbEntityValidationException innerException) :
                base(null, innerException)
            {
            }

            public override string Message
            {
                get
                {
                    var innerException = InnerException as DbEntityValidationException;
                    if (innerException == null) return base.Message;
                    var sb = new StringBuilder();

                    sb.AppendLine();
                    sb.AppendLine();
                    foreach (var eve in innerException.EntityValidationErrors)
                    {
                        sb.AppendLine(string.Format("- Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().FullName, eve.Entry.State));
                        foreach (var ve in eve.ValidationErrors)
                        {
                            sb.AppendLine(string.Format("-- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                                ve.PropertyName,
                                eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                                ve.ErrorMessage));
                        }
                    }
                    sb.AppendLine();

                    return sb.ToString();
                }
            }
        }
    }
}
