using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using UsedCars.Helpers;
using UsedCars.Models;

namespace UsedCars.Controllers
{
	public class CarController : ControllerBase
	{
		private readonly ICarService _service;
		private readonly IMapper _mapper;

		public CarController(ICarService service, IMapper mapper)
		{
			_service = service;
			_mapper = mapper;
		}
	}
}