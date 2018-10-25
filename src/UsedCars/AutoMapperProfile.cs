using AutoMapper;
using DAL.Entities;
using DAL.Helpers;
using UsedCars.Helpers;
using UsedCars.Models;

namespace UsedCars
{
	/// <summary>
	/// Profile for AutoMapper
	/// </summary>
	/// <seealso cref="AutoMapper.Profile" />
	public class AutoMapperProfile : Profile
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AutoMapperProfile"/> class.
		/// </summary>
		public AutoMapperProfile()
		{
			CreateMap<User, UserModel>().ReverseMap();
			CreateMap<Manufacturer, ManufacturerModel>().ReverseMap();
			CreateMap<DAL.Entities.CarModel, CarModelModel>().ReverseMap();
			CreateMap<Engine, EngineModel>().ReverseMap();
			CreateMap<EngineType, EngineTypeModel>().ReverseMap();
			CreateMap<TransmissionType, TransmissionTypeModel>().ReverseMap();
			CreateMap<Transmission, TransmissionModel>().ReverseMap();
			CreateMap<GearBoxType, GearBoxTypeModel>().ReverseMap();
			CreateMap<Car, Models.CarModel>().ReverseMap()
				.ForMember(x => x.CarModel, y => y.MapFrom(x => x.CarModelModel));
			CreateMap(typeof(SaveUpdateResult<User>), typeof(SaveUpdateResultModel<UserModel>)).ReverseMap();
		}
	}
}