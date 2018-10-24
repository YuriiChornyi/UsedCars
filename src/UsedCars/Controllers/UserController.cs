using System;
using AutoMapper;
using DAL.Entities;
using DAL.Helpers;
using Microsoft.AspNetCore.Mvc;
using Services;
using UsedCars.Helpers;
using UsedCars.Models;

namespace UsedCars.Controllers
{
	public class UserController : Controller
	{
		private readonly IUserService _service;
		private readonly IMapper _mapper;
		public UserController(IUserService service, IMapper mapper)
		{
			_service = service;
			_mapper = mapper;
		}

		/// <summary>
		/// Registers the specified name.
		/// </summary>
		/// <param name="name">The name.</param>
		/// <param name="email">The email.</param>
		/// <param name="phone">The phone.</param>
		[HttpPost]
		public SaveUpdateResultModel<UserModel> Register(string name, string email, string phone)
		{
			var user = new UserModel
			{
				Name = name,
				Email = email,
				Phone = phone,
				RegistrationDate = DateTime.Now
			};

			return _mapper.Map<SaveUpdateResult<User>, SaveUpdateResultModel<UserModel>>(_service.AddUserAsync(_mapper.Map<User>(user)));
		}
	}
}