using AutoMapper;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.DTOs.AddressDtos;
using WindPowerSystemV2.DTOs.ImageDtos;
using WindPowerSystemV2.Repositories.Models;
using WindPowerSystemV2.Repositories.Models.AddressModels;
using WindPowerSystemV2.Repositories.Models.ImageModels;

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

			CreateMap<ShareHolderType, ShareHolderTypeDto>()
				.ForMember(t => t.Name, opt => opt.MapFrom(expression => expression.Name))
				.IncludeAllDerived().ReverseMap();

			CreateMap<ShareHolder, ShareHolderDto>()
				.ForMember(t => t.FirstName, opt => opt.MapFrom(expression => expression.FirstName))
				.ForMember(t => t.LastName, opt => opt.MapFrom(expression => expression.LastName))
				.ForMember(t => t.Email, opt => opt.MapFrom(expression => expression.Email))
				.ForMember(t => t.Phone, opt => opt.MapFrom(expression => expression.Phone))
				.IncludeAllDerived().ReverseMap();

			CreateMap<Share, ShareDto>()
				.ForMember(t => t.SerialNum, opt => opt.MapFrom(expression => expression.SerialNum))
				.ForMember(t => t.Percent, opt => opt.MapFrom(expression => expression.Percent))
				.ForMember(t => t.Price, opt => opt.MapFrom(expression => expression.Price))
				.IncludeAllDerived().ReverseMap();

			CreateMap<AddressImage, AddressImageDto>()
				.ForMember(t => t.Path, opt => opt.MapFrom(expression => expression.Path))
				.IncludeAllDerived().ReverseMap();

			CreateMap<FlagImage, FlagImageDto>()
				.ForMember(t => t.Path, opt => opt.MapFrom(expression => expression.Path))
				.IncludeAllDerived().ReverseMap();

			CreateMap<AppImage, AppImageDto>()
				.ForMember(t => t.Path, opt => opt.MapFrom(expression => expression.Path))
				.IncludeAllDerived().ReverseMap();

			CreateMap<Country, CountryDto>()
				.ForMember(t => t.Name, opt => opt.MapFrom(expression => expression.Name))
				.IncludeAllDerived().ReverseMap();

			CreateMap<Town, TownDto>()
				.ForMember(t => t.Name, opt => opt.MapFrom(expression => expression.Name))
				.IncludeAllDerived().ReverseMap();
		}
	}
}
