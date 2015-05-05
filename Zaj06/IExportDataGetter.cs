using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaj06
{
    public interface IExportDataGetter
    {
        List<ExamResult> Get();
    }
}
