using AutoMapper;
using FitApp.ApplicationServices.API.Domain;
using FitApp.ApplicationServices.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.ApplicationServices.Mappings
{
    public class RecipesProfile : Profile
    {
       public RecipesProfile()
        {
            this.CreateMap<DataAccess.Entities.Recipe, Recipe>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(m => m.Name, y => y.MapFrom(z => z.Name))
                .ForMember(m => m.Kcal, y => y.MapFrom(z => z.Kcal))
                .ForMember(m => m.Description, y => y.MapFrom(z => z.Description))
                .ForMember(m => m.PreparationTime, y => y.MapFrom(z => z.PreparationTime)
                );

        }
    }
}
