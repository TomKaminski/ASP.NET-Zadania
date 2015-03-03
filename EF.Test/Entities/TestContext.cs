using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Security.AccessControl;
using EF.Test.Entities.TPH;

namespace EF.Test.Entities
{
    class TestContext:DbContext
    {
        public TestContext():base("SuperContext")
        {
            
        }
        public DbSet<Member> Members { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Team> Teams { get; set; }

        public DbSet<School> Schools { get; set; }
        public DbSet<Person> Persons { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .HasMany(x => x.Members)
                .WithMany(k => k.Projects).Map(k => k.ToTable("ProjsaSaSasectMemberess"))
                .Map(x => x.MapLeftKey("MemberId")).Map(j=>j.MapRightKey("ProjectId"));

            base.OnModelCreating(modelBuilder);
        }

        public class DbInitializer : DropCreateDatabaseIfModelChanges<TestContext>
        {
            protected override void Seed(TestContext context)
            {
                context.Teams.Add(new Team
                {
                    Name = "SuperImie",
                    Members = new List<Member>
                    {
                        new Member
                        {
                            MemberTitle = EMemberTitle.Developer,
                            Name="SuperMember",
                            Projects = new List<Project>
                            {
                                new Project
                                {
                                    Name="SuperProject"
                                }
                            }
                        },
                        new Member
                        {
                            MemberTitle = EMemberTitle.ScrumMaster,
                            Name="SuperMember2",
                            Projects = new List<Project>
                            {
                                new Project
                                {
                                    Name="SuperProject2"
                                }
                            }
                        }
                    }
                });
                context.Teams.Add(new Team
                {
                    Name = "SuperImie2",
                    Members = new List<Member>
                    {
                        new Member
                        {
                            MemberTitle = EMemberTitle.Developer,
                            Name="SuperMember3",
                            Projects = new List<Project>
                            {
                                new Project
                                {
                                    Name="SuperProject3"
                                }
                            }
                        },
                        new Member
                        {
                            MemberTitle = EMemberTitle.ScrumMaster,
                            Name="SuperMember4",
                            Projects = new List<Project>
                            {
                                new Project
                                {
                                    Name="SuperProject4"
                                }
                            }
                        }
                    }
                });

                context.Schools.Add(new School
                {
                    Persons = new List<Person>
                    {
                        new Teacher {Name = "Teacher1", Title = "Asd"},
                        new Teacher {Name = "Teacher2", Title = "Asd2"},
                        new Student {Name = "Teacher1", IndexNo = 1231},
                        new Student {Name = "Teacher2", IndexNo = 4324},
                    }
                });
                context.SaveChanges();
                base.Seed(context);
            }
        }    
    }
}
