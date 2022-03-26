using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Models;

namespace MoviesAPI.Profiles
{
  public class AddressProfile : Profile
  {
    public AddressProfile()
    {

      CreateMap<CreateAddressDto, Address>();
      CreateMap<Address, ReadAddressDto>()
      ;
      CreateMap<UpdateAddressDto, Address>();
    }
  }
}