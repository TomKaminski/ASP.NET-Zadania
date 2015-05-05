using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zaj06
{
    public class ExportManager
    {
        private readonly IExport _exporter;
        private readonly IExportDataGetter _exportDataGetter;

        public ExportManager(IExport exporter, IExportDataGetter exportDataGetter)
        {
            _exporter = exporter;
            _exportDataGetter = exportDataGetter;
        }

        public string RunExport(List<ExamResult> list = null)
        {
            return _exporter.Export(list ?? _exportDataGetter.Get());
        }
    }
}
