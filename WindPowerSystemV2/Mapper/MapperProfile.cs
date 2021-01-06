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

			CreateMap<Turbine, TurbineDto>()
				.ForMember(t => t.SerialNum, opt => opt.MapFrom(expression => expression.SerialNum))
				.ForMember(t => t.ProdMW, opt => opt.MapFrom(expression => expression.ProdMW))
				.IncludeAllDerived().ReverseMap();

			CreateMap<Share, ShareDto>()
				.ForMember(t => t.SerialNum, opt => opt.MapFrom(expression => expression.SerialNum))
				.ForMember(t => t.Percent, opt => opt.MapFrom(expression => expression.Percent))
				.ForMember(t => t.Price, opt => opt.MapFrom(expression => expression.Price))
				.IncludeAllDerived().ReverseMap();
		}
	}
}
