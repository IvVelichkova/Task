using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GVC.Data.Models;
using GVC.Views.Models;

namespace GVC.Services.EventsService
{
    public interface IEventService
    {
        void CreateEvent();
        List<EventViewModelcs> AllEventsServiceMethod();
        Task<EventViewModelcs> FindToEdit(int Id);
        void EditEvent(EventViewModelcs model);
        void DeleteEvent(EventViewModelcs eve);
    }
}
