using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using UsedCars.Models;

namespace UsedCars.Controllers
{
	public class ManufacturerController : ControllerBase
	{
		private readonly IManufacturerService _service;
		private readonly IMapper _mapper;
		public ManufacturerController(IManufacturerService service, IMapper mapper)
		{
			_service = service;
			_mapper = mapper;
		}

		[HttpGet]
		public List<ManufacturerModel> GetManufacturers()
		{
			return _mapper.Map<List<ManufacturerModel>>(_service.GetManufacturers());
		}

		[HttpGet]
		public List<CarModelModel> GetManufacturerModels(int manufacturerId)
		{
			return _mapper.Map<List<CarModelModel>>(_service.GetCarModelsByManufacturerId(manufacturerId));
		}
	}
}