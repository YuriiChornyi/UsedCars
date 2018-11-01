using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DAL.Entities;
using DAL.Helpers;

namespace Services.Services
{
	public class CarService: ICarService
	{
		private readonly IRepository<Car> _repository;
		public CarService(IRepository<Car> repository)
		{
			_repository = repository;
		}
		public SaveUpdateResult<Car> CreateCar(int engineId, int transmissionId, int carModelId, DateTime? productionYear, string vinCode)
		{
			Car c = new Car
			{
				CarModelId = carModelId,
				TransmissionId = transmissionId,
				EngineId = engineId,
				ProductionYear = productionYear,
				VinCode = vinCode
			};

			return _repository.AddAsync(c);
		}
	}
}
