using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Event_MS.Models;
using Event_MS.Requests;

namespace Event_MS.Profiles
{
    public class EventProfiles : Profile
    {
        public EventProfiles()
        {
            CreateMap<AddUser,UserClass>().ReverseMap();
            
        }
    }
}
