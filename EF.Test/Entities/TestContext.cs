#region

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using EF.Test.Entities.TPH;

#endregion

namespace EF.Test.Entities
{
    internal class TestContext : DbContext
    {
        public TestContext() : base("SuperContext")
        {
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<ProjectMembers> ProjectMembers { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Member>()
            //    .HasMany(x => x.Projects)
            //    .WithMany(k => k.Members)
            //    .Map(x =>
            //    {
            //        x.MapLeftKey("ProjectId");
            //        x.MapRightKey("MemberId");
            //        x.ToTable("MembersOfProjects");
            //    });

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

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
                            Name = "SuperMember",
                        },
                        new Member
                        {
                            MemberTitle = EMemberTitle.ScrumMaster,
                            Name = "SuperMember2",
                        }
                    }
                });
                context.SaveChanges();
                context.Teams.Add(new Team
                {
                    Name = "SuperImie2",
                    Members = new List<Member>
                    {
                        new Member
                        {
                            MemberTitle = EMemberTitle.Developer,
                            Name = "SuperMember3",
                        },
                        new Member
                        {
                            MemberTitle = EMemberTitle.ScrumMaster,
                            Name = "SuperMember4",
                        }
                    }
                });
                context.SaveChanges();
                context.Projects.Add(new Project
                {
                    Name = "Projekt1",
                    ProjectMembers = new List<ProjectMembers>
                    {
                        new ProjectMembers {MemberId = 1, StartDate = DateTime.Now},
                        new ProjectMembers {MemberId = 3, StartDate = DateTime.Now}
                    }
                });
                context.SaveChanges();
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
                context.Shops.Add(new Shop
                {
                    Name = "AthSHop",
                    Products = new List<Product>
                    {
                        new Bike {EBikeType = EBikeType.Downhill, Name = "BMX", Price = 100.5m},
                        new Bike {EBikeType = EBikeType.Downhill, Name = "sdfsdf", Price = 100.5m},
                        new Bike {EBikeType = EBikeType.Downhill, Name = "sfdfds", Price = 100.5m},
                        new Bike {EBikeType = EBikeType.Downhill, Name = "BMfsdfsdfsdfsdX", Price = 100.5m},
                        new Tire {Name = "Opona 2", Price = 42m, Size = 50},
                        new Tire {Name = "Opona 3", Price = 555m, Size = 30}
                    }
                });
                base.Seed(context);
            }
        }
    }
}