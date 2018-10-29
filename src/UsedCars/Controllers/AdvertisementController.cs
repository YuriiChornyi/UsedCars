using AutoMapper;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using UsedCars.Helpers;
using UsedCars.Models;

namespace UsedCars.Controllers
{
	/// <summary>
	/// AdvertisementController
	/// </summary>
	/// <seealso cref="ControllerBase" />
	public class AdvertisementController : ControllerBase
	{
		private readonly IAdvertisementService _service;
		private readonly IMapper _mapper;

		public AdvertisementController(IAdvertisementService service, IMapper mapper)
		{
			_service = service;
			_mapper = mapper;
		}

		[HttpPost]
		public SaveUpdateResultModel<AdvertisementModel> CreateAdvertisement([FromBody] AdvertisementModel advertisement)
		{
			return _mapper.Map<SaveUpdateResultModel<AdvertisementModel>>(
				_service.CreateAdvertisement(_mapper.Map<Advertisement>(advertisement)));
		}
	}
}