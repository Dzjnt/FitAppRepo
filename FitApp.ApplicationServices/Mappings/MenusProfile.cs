using AutoMapper;
using FitApp.ApplicationServices.API.Domain;
using FitApp.ApplicationServices.API.Domain.MenuRequests;
using FitApp.ApplicationServices.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.ApplicationServices.Mappings
{
    public  class MenusProfile : Profile
    {
        public MenusProfile()
        {
            this.CreateMap<FitApp.DataAccess.Entities.Menu, Menu>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(m => m.UserId, y => y.MapFrom(z => z.UserId));

            this.CreateMap<AddMenuRequest, FitApp.DataAccess.Entities.Menu>()
               .ForMember(x => x.Id, y => y.MapFrom(z => z.Number));

            this.CreateMap<DeleteMenuRequest, FitApp.DataAccess.Entities.Menu>()
              .ForMember(x => x.Id, y => y.MapFrom(z => z.Number));

        }

    }
}
