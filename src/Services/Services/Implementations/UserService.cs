using System;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using DAL;
using AutoMapper;
using DAL.Entities;
using DAL.Helpers;
using DAL.Repositories;

namespace Services
{
	public class UserService : IUserService
	{
		private readonly IUserRepository _userRepository;
		private readonly IMapper _mapper;
		public UserService(IUserRepository userRepository, IMapper mapper)
		{
			_userRepository = userRepository;
			_mapper = mapper;
		}

		public SaveUpdateResult<User> AddUserAsync(string name, string email, string phone)
		{
			User u = new User() {Email = email, Name = name, Phone = phone, RegistrationDate = DateTime.Now};
			return _userRepository.AddAsync(u);
		}

		public void RemoveUser(User userToRemove)
		{
			_userRepository.Remove(userToRemove.UserId);
		}
	}
}