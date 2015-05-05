using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Microsoft.Practices.Unity;

namespace Zaj06
{
    class Program
    {
        static void Main(string[] args)
        {
            //var builder = new ContainerBuilder();

            //builder.RegisterType<CsvExporter>().As<IExport>();
            ////builder.RegisterType<JsonExporter>().As<IExport>();
            //builder.RegisterType<ExportManager>();
            //builder.RegisterType<StaticDataGetter>().As<IExportDataGetter>();
            //var cont = builder.Build();

            IUnityContainer container = new UnityContainer();

            container.RegisterType<IExport, JsonExporter>();
            container.RegisterType<IExportDataGetter, StaticDataGetter>();


            var list = new List<ExamResult>
            {
                new ExamResult {Grade = 5, IndexNo = Guid.NewGuid()},
                new ExamResult {Grade = 4, IndexNo = Guid.NewGuid()},
                new ExamResult {Grade = 1, IndexNo = Guid.NewGuid()},
                new ExamResult {Grade = 3, IndexNo = Guid.NewGuid()},
                new ExamResult {Grade = 63, IndexNo = Guid.NewGuid()},
            };

            //var exp = cont.Resolve<ExportManager>();

            var exp = container.Resolve<ExportManager>();
            Console.WriteLine(exp.RunExport(list));
            
            Console.WriteLine();
        }
    }
}
