using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GVC.Data.Models;
using GVC.Views.Models;

namespace GVC
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<OddEvents, EventViewModelcs>();
        }
    }
}
