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

		public SaveUpdateResult<User> AddUserAsync(User userToAdd) =>_userRepository.AddAsync(userToAdd);

		public void RemoveUser(User userToRemove)
		{
			_userRepository.Remove(userToRemove.UserId);
		}
	}
}