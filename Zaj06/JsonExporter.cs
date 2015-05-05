using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zaj06
{
    public class JsonExporter:IExport
    {
        public string Export(List<ExamResult> examResults)
        {
            return JsonConvert.SerializeObject(examResults);
        }
    }
}
