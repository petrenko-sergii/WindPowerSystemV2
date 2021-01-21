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

			CreateMap<Index, IndexDto>()
				.ForMember(t => t.Value, opt => opt.MapFrom(expression => expression.Value))
				.IncludeAllDerived().ReverseMap();

			CreateMap<Street, StreetDto>()
				.ForMember(t => t.Name, opt => opt.MapFrom(expression => expression.Name))
				.IncludeAllDerived().ReverseMap();

			CreateMap<BuildingNumber, BuildingNumberDto>()
				.ForMember(t => t.Value, opt => opt.MapFrom(expression => expression.Value))
				.ForMember(t => t.Latitude, opt => opt.MapFrom(expression => expression.Latitude))
				.ForMember(t => t.Longitude, opt => opt.MapFrom(expression => expression.Longitude))
				.IncludeAllDerived().ReverseMap();

			CreateMap<FlatPart, FlatPartDto>()
				.ForMember(t => t.Value, opt => opt.MapFrom(expression => expression.Value))
				.ForMember(t => t.Name, opt => opt.MapFrom(expression => expression.Name))
				.IncludeAllDerived().ReverseMap();

			CreateMap<Address, AddressDto>()
				.ForMember(t => t.CountryId, opt => opt.MapFrom(expression => expression.Country.Id))
				.ForMember(t => t.Country, opt => opt.MapFrom(expression => expression.Country.Name))
				.ForMember(t => t.IndexId, opt => opt.MapFrom(expression => expression.Index.Id))
				.ForMember(t => t.Index, opt => opt.MapFrom(expression => expression.Index.Value))
				.ForMember(t => t.TownId, opt => opt.MapFrom(expression => expression.Town.Id))
				.ForMember(t => t.Town, opt => opt.MapFrom(expression => expression.Town.Name))
				.ForMember(t => t.StreetId, opt => opt.MapFrom(expression => expression.Street.Id))
				.ForMember(t => t.Street, opt => opt.MapFrom(expression => expression.Street.Name))
				.ForMember(t => t.BuildingNumberId, opt => opt.MapFrom(expression => expression.BuildingNumber.Id))
				.ForMember(t => t.BuildingNumber, opt => opt.MapFrom(expression => expression.BuildingNumber.Value))
				.ForMember(t => t.FlatPartId, opt => opt.MapFrom(expression => expression.FlatPart.Id))
				.ForMember(t => t.FlatPart, opt => opt.MapFrom(expression => expression.FlatPart.Name))
				.IncludeAllDerived().ReverseMap();

			CreateMap<Operator, OperatorDto>()
				.ForMember(t => t.Name, opt => opt.MapFrom(expression => expression.Name))
				.ForMember(t => t.Phone, opt => opt.MapFrom(expression => expression.Phone))
				.ForMember(t => t.Email, opt => opt.MapFrom(expression => expression.Email))
				.ForMember(t => t.Website, opt => opt.MapFrom(expression => expression.Website))
				.IncludeAllDerived().ReverseMap();

			CreateMap<Manufacturer, ManufacturerDto>()
				.ForMember(t => t.Name, opt => opt.MapFrom(expression => expression.Name))
				.ForMember(t => t.Phone, opt => opt.MapFrom(expression => expression.Phone))
				.ForMember(t => t.Email, opt => opt.MapFrom(expression => expression.Email))
				.ForMember(t => t.Website, opt => opt.MapFrom(expression => expression.Website))
				.IncludeAllDerived().ReverseMap();

			CreateMap<Unit, UnitDto>()
				.ForMember(t => t.Name, opt => opt.MapFrom(expression => expression.Name))
				.IncludeAllDerived().ReverseMap();

			CreateMap<WorkState, WorkStateDto>()
				.ForMember(t => t.Name, opt => opt.MapFrom(expression => expression.Name))
				.IncludeAllDerived().ReverseMap();

			CreateMap<Farm, FarmDto>()
				.ForMember(t => t.Name, opt => opt.MapFrom(expression => expression.Name))
				.IncludeAllDerived().ReverseMap();

			CreateMap<MeterItem, MetreItemDto>()
				.ForMember(t => t.MeasureDate, opt => opt.MapFrom(expression => expression.MeasureDate))
				.ForMember(t => t.Value, opt => opt.MapFrom(expression => expression.Value))
				.ForMember(t => t.CurProdCapacity, opt => opt.MapFrom(expression => expression.CurProdCapacity))
				.ForMember(t => t.HourQty, opt => opt.MapFrom(expression => expression.HourQty))
				.ForMember(t => t.AverageWind, opt => opt.MapFrom(expression => expression.AverageWind))
				.ForMember(t => t.AverageDensity, opt => opt.MapFrom(expression => expression.AverageDensity))
				.IncludeAllDerived().ReverseMap();

			CreateMap<User, UserDto>()
				.ForMember(t => t.Email, opt => opt.MapFrom(expression => expression.Email))
				.ForMember(t => t.Phone, opt => opt.MapFrom(expression => expression.Phone))
				.ForMember(t => t.RegisterDate, opt => opt.MapFrom(expression => expression.RegisterDate))
				.ForMember(t => t.LastLoginDate, opt => opt.MapFrom(expression => expression.LastLoginDate))
				.ForMember(t => t.Firstname, opt => opt.MapFrom(expression => expression.Firstname))
				.ForMember(t => t.LastName, opt => opt.MapFrom(expression => expression.LastName))
				.ForMember(t => t.WrongPassworDeffort, opt => opt.MapFrom(expression => expression.WrongPassworDeffort))
				.ForMember(t => t.Blocked, opt => opt.MapFrom(expression => expression.Blocked))
				.ForMember(t => t.PasswordMustBeChanged, opt => opt.MapFrom(expression => expression.PasswordMustBeChanged))
				.ForMember(t => t.LifeTimeForPassword, opt => opt.MapFrom(expression => expression.LifeTimeForPassword))
				.IncludeAllDerived().ReverseMap();
		}
	}
}
