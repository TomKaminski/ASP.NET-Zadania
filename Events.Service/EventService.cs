using System;
using System.Collections.Generic;
using System.Linq;
using Events.Common;
using Events.Contract.DTO;
using Events.Contract.Service;
using Events.Dal.Model;
using Events.Dal.Repository;

namespace Events.Service
{
    public class EventService:IEventService
    {
        private readonly IRepository<EventTypes> _repository;

        public EventService(IRepository<EventTypes> repository)
        {
            _repository = repository;
        }

        public void Add(EventTypeDto eventTypeDto)
        {
            _repository.Add(new EventTypes
            {
                Name = eventTypeDto.Name
            });
            _repository.Commit();
        }

        public List<EventTypeDtoResult> GetAll()
        {
            return _repository.GetAll().Select(n => new EventTypeDtoResult
            {
                ServiceStatus = EServiceStatus.Ok
            }).ToList();
        }
    }
}
