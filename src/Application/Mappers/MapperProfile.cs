using Application.Responses;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Item, ItemResponse>();
        }
    }
}