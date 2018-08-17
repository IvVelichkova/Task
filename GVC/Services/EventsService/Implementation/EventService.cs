using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using GVC.Data;
using GVC.Data.Models;
using GVC.Views.Models;
using Microsoft.EntityFrameworkCore;

namespace GVC.Services.EventsService.Implementation
{
    public class EventService : IEventService
    {
        private readonly DbGVCContext db;
        private readonly IMapper _mapper;

        public EventService(DbGVCContext db, IMapper mapper)
        {
            this.db = db;
            this._mapper = mapper;
        }

     

        public void CreateEvent()
        {

            var ev = new OddEvents();
            var time = DateTime.UtcNow.Date.ToShortDateString();
            var hour = "23:59";
            var date = time + " " + hour;
            ev.EventStartDate = DateTime.Parse(date);

            this.db.Events.Add(ev);
            db.SaveChanges();

        }


        public List<EventViewModelcs> AllEventsServiceMethod()
        {
            var result = new List<EventViewModelcs>();
            foreach (var item in this.db.Events)
            {

                var res = _mapper.Map<EventViewModelcs>(item);
                result.Add(res);
            }
            //var even = _mapper.Map<EventViewModelcs>(this.db.Events);
            return result;
        }


        public async Task<EventViewModelcs> FindToEdit(int Id)
        {
            var model=await this.db
         .Events.Where(r => r.EventId == Id)
        .ProjectTo<EventViewModelcs>(_mapper.ConfigurationProvider)
        .SingleOrDefaultAsync();
            return model;
        }


        public void EditEvent(EventViewModelcs model)
        {

        
            var ev = this.db.Events.Find(model.EventId);
            ev.EventId = model.EventId;
            ev.EventStartDate = DateTime.Parse(model.EventStartDate);
            ev.NameEvent = model.EventName;
            ev.OddsForFirstTeam = Decimal.Parse(String.Format("{0:F2}", model.OddsForFirstTeam));
            ev.OddsForDraw = Decimal.Parse(String.Format("{0:F2}", model.OddsForDraw));
            ev.OddsForFirstTeam = Decimal.Parse(String.Format("{0:F2}", model.OddsForSecondTeam));

           

            this.db.Events.Update(ev);
            this.db.SaveChanges();
        }

        public void DeleteEvent(EventViewModelcs eve)
        {

            var ev = this.db.Events.Where(e => e.EventId == eve.EventId).FirstOrDefault();

            db.Events.Remove(ev);
            this.db.SaveChangesAsync();
        }
    }
}
