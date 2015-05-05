using System.Web.Mvc;
using Events.Contract.DTO;
using Events.Contract.Service;
using Events.GUI.ViewModel;

namespace Events.GUI.Controllers
{
    public class EventTypeController : Controller
    {
        private readonly IEventService _eventService;

        public EventTypeController(IEventService eventService)
        {
            _eventService = eventService;
        }

        // GET: EventType
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EventTypeViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            _eventService.Add(new EventTypeDto
            {
                Name = model.Name
            });
            return RedirectToAction("Index");
        }
    }
}