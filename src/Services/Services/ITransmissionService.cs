using System.Collections.Generic;
using DAL.Entities;
using DAL.Helpers;

namespace Services.Services
{
	public interface ITransmissionService
	{
		List<TransmissionType> GetTrasmissionTypes();

		List<GearBoxType> GetGearBoxTypes();

		SaveUpdateResult<Transmission> CreateTransmission(int gearBoxTypeId, int transmissionTypeId);
	}
}
