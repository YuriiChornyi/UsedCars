﻿using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using UsedCars.Helpers;
using UsedCars.Models;

namespace UsedCars.Controllers
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
	public class EngineController : ControllerBase
	{
		private readonly IEngineService _service;
		private readonly IMapper _mapper;
		public EngineController(IEngineService service, IMapper mapper)
		{
			_service = service;
			_mapper = mapper;
		}

		[HttpGet]
		public List<EngineTypeModel> GetEngineTypes()
		{
			return _mapper.Map<List<EngineTypeModel>>(_service.GetEngineTypes());
		}

		[HttpPost]
		public SaveUpdateResultModel<EngineModel> CreateEngine(int engineTypeId, string value, int hp)
		{
			return _mapper.Map<SaveUpdateResultModel<EngineModel>>(_service.CreateEngine(engineTypeId, value, hp));
		}
	}
}