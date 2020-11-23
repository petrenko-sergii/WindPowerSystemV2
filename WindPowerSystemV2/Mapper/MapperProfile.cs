using AutoMapper;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.Repositories.Models;

namespace WindPowerSystemV2.Mapper
{
	public class MapperProfile : Profile
	{
		public MapperProfile()
		{
			CreateMap<TurbineType, TurbineTypeDto>()
				.ForMember(t => t.Model, opt => opt.MapFrom(expression => expression.Model))
				.ForMember(t => t.Capacity, opt => opt.MapFrom(expression => expression.Capacity))
				.IncludeAllDerived().ReverseMap();
		}
	}
}
