using Events.Common;

namespace Events.Contract.DTO
{
    public class DtoResultBase
    {
        public string Message { get; set; }
        public EServiceStatus ServiceStatus { get; set; }
    }

}
