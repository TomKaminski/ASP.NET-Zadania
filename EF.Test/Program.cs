using System;
using System.Data.Entity;
using System.Linq;
using EF.Test.Entities;
using EF.Test.Entities.TPH;

namespace EF.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory",AppDomain.CurrentDomain.BaseDirectory);
            Database.SetInitializer(new TestContext.DbInitializer());

            using (var db = new TestContext())
            {
                var plz = db.Members.Select(x => x).ToList();
                foreach (var member in plz)
                {
                    Console.WriteLine("Team name: {0} ------ MemberName: {1}", member.Team.Name, member.Name);
                }

                var plz2 = db.Persons.OfType<Student>().Select(x => x);
                foreach (var item in plz2)
                {
                    Console.WriteLine(item.Name);

                }
            }
        }
    }


}
