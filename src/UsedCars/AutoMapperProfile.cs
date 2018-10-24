using AutoMapper;
using DAL.Entities;
using DAL.Helpers;
using UsedCars.Helpers;
using UsedCars.Models;

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
			CreateMap(typeof(SaveUpdateResult<User>), typeof(SaveUpdateResultModel<UserModel>));
		}
	}
}