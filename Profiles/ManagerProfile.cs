using AutoMapper;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Profiles
{
  public class ManagerProfile : Profile
  {
    public ManagerProfile()
    { 
        CreateMap<CreateManagerDto, Manager>();
        CreateMap<Manager, ReadManagerDto>()
        .ForMember(manager => manager.Cinemas, opts => opts
        .MapFrom(manager => manager.Cinemas.Select
        (c => new {c.Id, c.Name, c.Address, c.AddressId})
        ));
      }
  }
}