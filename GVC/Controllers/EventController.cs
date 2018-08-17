using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GVC.Services.EventsService;
using GVC.Views.Models;
using Microsoft.AspNetCore.Mvc;

namespace GVC.Controllers
{
    public class EventController:Controller
    {
        private readonly IEventService eventService;
        private readonly IMapper _mapper;

        public EventController(IEventService eventService, IMapper mapper)
        {
            this.eventService = eventService;
            this._mapper = mapper;
        }
        [HttpPost]
        public IActionResult Create()
        {
            this.eventService.CreateEvent();
            return RedirectToAction("All");
        }

        public IActionResult All()
        {

           
            var res = this.eventService.AllEventsServiceMethod();
           
                
            return View(res);
        }

        public IActionResult EditMode()
        {
            var res = this.eventService.AllEventsServiceMethod();


            return View(res);
        }

        public async Task< IActionResult>  Edit(int id)
        {

            var ev =await eventService.FindToEdit(id);
            //if (ev == null)
            //{
            //    return NotFound();
            //}
            return View(ev);
           
        }
        [HttpPost]
        public IActionResult Edit(int id, EventViewModelcs ev)
        {
           
            this.eventService.EditEvent(ev);
           
           

            return RedirectToAction("All", "Event");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var ev = await eventService.FindToEdit(id);
            this.eventService.DeleteEvent(ev);

         return   RedirectToAction("All", "Event");

        }
    }
}
