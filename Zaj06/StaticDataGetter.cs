using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaj06
{
    public class StaticDataGetter:IExportDataGetter
    {
        public List<ExamResult> Get()
        {
            return new List<ExamResult>
            {
                new ExamResult {Grade = 5, IndexNo = Guid.NewGuid()},
                new ExamResult {Grade = 4, IndexNo = Guid.NewGuid()},
                new ExamResult {Grade = 1, IndexNo = Guid.NewGuid()},
                new ExamResult {Grade = 3, IndexNo = Guid.NewGuid()},
                new ExamResult {Grade = 63, IndexNo = Guid.NewGuid()},
            };
        }
    }
}
