using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using EF.Test.Entities;


namespace EF.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory",AppDomain.CurrentDomain.BaseDirectory);
            System.Data.Entity.Database.SetInitializer(new TestContext.DbInitializer());
            var connection =  ConfigurationManager.ConnectionStrings["SuperContext"].ConnectionString;            
            using (var db = new TestContext())
            {               
                var start = DateTime.Now;
                var plz3 = db.Projects.Select(x => new{x.Name,x.Id}).ToList();
                Console.WriteLine(DateTime.Now - start);
                foreach (var project in plz3)
                {
                    Console.WriteLine("Project: {0} - {1}",project.Id,project.Name);                    
                }
            }

            using (var con = new SqlConnection(connection))
            {
                var start = DateTime.Now;
                var plz = con.Query<Project>("select Name, Id from Project").Select(x=>new
                {
                    x.Name,
                    x.Id
                }).ToList();
                Console.WriteLine(DateTime.Now - start);
                foreach (var project in plz)
                {
                    Console.WriteLine("Project: {0} - {1}", project.Id, project.Name);     
                }

                var start2 = DateTime.Now;
                var plz2 = con.GetList<Project>().Select(x => new
                {
                    x.Name,
                    x.Id
                }).ToList();
                Console.WriteLine(DateTime.Now - start2);
                foreach (var project in plz2)
                {
                    Console.WriteLine("Project: {0} - {1}", project.Id, project.Name);    
                }
                
            }
        }
    }


}
