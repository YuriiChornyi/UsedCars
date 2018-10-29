using System.Collections.Generic;
using System.Linq;
using DAL;
using DAL.Entities;
using DAL.Helpers;

namespace Services.Services
{
	public class TransmissionService :ITransmissionService
	{
		private readonly IRepository<Transmission> _transmissionRepository;

		public TransmissionService(IRepository<Transmission> transmission,
			IRepository<TransmissionType> transmissionType, IRepository<GearBoxType> gearBoxType)
		{
			_transmissionRepository = transmission;
		}

		public List<Transmission> GetTrasmissions()
		{
			return _transmissionRepository.GetAll().ToList();
		}

		public SaveUpdateResult<Transmission> CreateTransmission(int gearBoxTypeId, int transmissionTypeId)
		{
			return _transmissionRepository.AddAsync(new Transmission()
				{GearBoxTypeId = gearBoxTypeId, TransmissionTypeId = transmissionTypeId});
		}
	}
}
