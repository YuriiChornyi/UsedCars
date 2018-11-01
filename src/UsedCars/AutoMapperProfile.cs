﻿using AutoMapper;
using DAL.Entities;
using DAL.Helpers;
using UsedCars.Controllers;
using UsedCars.Helpers;
using UsedCars.Models;
using AdvertisementD = DAL.DapperEntities.Advertisement;

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
			CreateMap<Car, Models.CarModel>().ReverseMap();
			CreateMap<Advertisement, AdvertisementModel>().ReverseMap();
			CreateMap<AdvertisementD, AdvertisementDModel>().ReverseMap();
			CreateMap<Photo, PhotoModel>().ReverseMap();


			CreateMap(typeof(SaveUpdateResult<User>), typeof(SaveUpdateResultModel<UserModel>)).ReverseMap();
			CreateMap(typeof(ListDtoModel<AdvertisementD>), typeof(ListDto<AdvertisementDModel>)).ReverseMap();
		}
	}
}