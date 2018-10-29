using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
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
		public List<TransmissionModel> GetTransmissions()
		{
			return _mapper.Map<List<TransmissionModel>>(_service.GetTrasmissions());
		}
	}
}