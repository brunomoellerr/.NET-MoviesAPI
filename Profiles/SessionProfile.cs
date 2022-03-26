using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Models;

namespace MoviesAPI.Profiles
{
  public class SessionProfile : Profile
  {
    public SessionProfile()
    {
      CreateMap<CreateSessionDto, Session>();
      CreateMap<Session, ReadSessionDto>()
      .ForMember(session => session.StartTime, opts => opts
      .MapFrom(session => session.EndTime.AddMinutes(session.Movie.Duration * (-1)))
      )
      ;
    }
  }
}