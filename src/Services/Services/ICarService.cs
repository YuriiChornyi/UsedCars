using System;
using DAL.Entities;
using DAL.Helpers;

namespace Services.Services
{
	public interface ICarService
	{
		SaveUpdateResult<Car> CreateCar(int engineId, int transmissionId, int carModelId, DateTime? productionYear,
			string vinCode);
	}
}
