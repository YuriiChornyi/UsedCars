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
		private readonly IRepository<TransmissionType> _transmissionTypeRepository;
		private readonly IRepository<GearBoxType> _gearBoxTypeRepository;

		public TransmissionService(IRepository<Transmission> transmission, IRepository<TransmissionType> transmissionType, IRepository<GearBoxType> gearBoxType)
		{
			_transmissionRepository = transmission;
			_transmissionTypeRepository = transmissionType;
			_gearBoxTypeRepository = gearBoxType;
		}
		public List<TransmissionType> GetTrasmissionTypes()
		{
			return _transmissionTypeRepository.GetAll().ToList();
		}

		public List<GearBoxType> GetGearBoxTypes()
		{
			return _gearBoxTypeRepository.GetAll().ToList();
		}

		public SaveUpdateResult<Transmission> CreateTransmission(int gearBoxTypeId, int transmissionTypeId)
		{
			return _transmissionRepository.AddAsync(new Transmission()
				{GearBoxTypeId = gearBoxTypeId, TransmissionTypeId = transmissionTypeId});
		}
	}
}
