using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Models;

namespace MoviesAPI.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
      CreateMap<CreateMovieDto, Movie>();
      CreateMap<Movie, ReadMovieDto>();
      CreateMap<UpdateMovieDto, Movie>();
    }
    }
}