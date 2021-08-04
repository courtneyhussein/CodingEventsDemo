using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEventsDemo.Data;
using CodingEventsDemo.Models;
using CodingEventsDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coding_events_practice.Controllers
{
    public class EventsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
<<<<<<< HEAD
            List<string> Events = new List<string>();
            Events.Add("Code With Pride");
            Events.Add("Apple WWDC");
            Events.Add("Strange Loop");

            ViewBag.events = Events;
=======
            List<Event> events = new List<Event>(EventData.GetAll());
>>>>>>> fa3391eddee12f2fdd319d92e599b195fc811d1f

            return View(events);
        }
<<<<<<< HEAD
=======

        public IActionResult Add()
        {
            AddEventViewModel addEventViewModel = new AddEventViewModel();

            return View(addEventViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddEventViewModel addEventViewModel)
        {
            if (ModelState.IsValid)
            {
                Event newEvent = new Event
                {
                    Name = addEventViewModel.Name,
                    Description = addEventViewModel.Description,
                    ContactEmail = addEventViewModel.ContactEmail,
                    Type = addEventViewModel.Type
                };

                EventData.Add(newEvent);

                return Redirect("/Events");
            }

            return View(addEventViewModel);
        }

        public IActionResult Delete()
        {
            ViewBag.events = EventData.GetAll();

            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] eventIds)
        {
            foreach (int eventId in eventIds)
            {
                EventData.Remove(eventId);
            }

            return Redirect("/Events");
        }
>>>>>>> fa3391eddee12f2fdd319d92e599b195fc811d1f
    }
}
