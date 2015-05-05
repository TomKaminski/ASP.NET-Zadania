using System.Collections.Generic;
using Events.Contract.DTO;

namespace Events.Contract.Service
{
    public interface IEventService
    {
        void Add(EventTypeDto eventTypeDto);
        List<EventTypeDtoResult> GetAll();
    }

    
}
