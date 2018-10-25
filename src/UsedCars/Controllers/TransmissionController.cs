using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using UsedCars.Helpers;
using UsedCars.Models;

namespace UsedCars.Controllers
{
	public class TransmissionController : ControllerBase
	{
		private readonly ITransmissionService _service;
		private readonly IMapper _mapper;

		public TransmissionController(ITransmissionService service, IMapper mapper)
		{
			_service = service;
			_mapper = mapper;
		}

		[HttpGet]
		public List<TransmissionTypeModel> GetTransmissionTypes()
		{
			return _mapper.Map<List<TransmissionTypeModel>>(_service.GetTrasmissionTypes());
		}

		[HttpGet]
		public List<GearBoxTypeModel> GearBoxTypes()
		{
			return _mapper.Map<List<GearBoxTypeModel>>(_service.GetGearBoxTypes());
		}

		[HttpPost]
		public SaveUpdateResultModel<TransmissionModel> CreateTransmission(int gearBoxTypeId, int transmissionTypeId)
		{
			return _mapper.Map<SaveUpdateResultModel<TransmissionModel>>(
				_service.CreateTransmission(gearBoxTypeId, transmissionTypeId));
		}
	}
}