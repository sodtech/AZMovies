using A2ZMOVIES.Dtos;
using A2ZMOVIES.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A2ZMOVIES.App_Start
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(m=>m.id,opt=>opt.Ignore());
            Mapper.CreateMap<MemberShipType, MemberShipTypeDto>();

            Mapper.CreateMap<Movies, MovieDto>();
            Mapper.CreateMap<MovieDto, Movies>().ForMember(m=>m.Id,opt=>opt.Ignore());
            Mapper.CreateMap<MovieGenre, MovieGenreDto>();

            Mapper.CreateMap<NewRentalDto, NewRentals>();
        }
    }
}