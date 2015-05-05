using System.Collections.Generic;
using System.Text;

namespace Zaj06
{
    public class CsvExporter:IExport
    {

        public string Export(List<ExamResult> examResults)
        {
            var sb = new StringBuilder();

            foreach (var examResult in examResults)
            {
                sb.AppendFormat("{0};{1}", examResult.IndexNo, examResult.Grade);
            }
            return sb.ToString();
        }
    }
}
