using System.Collections.Generic;
using DAL.Entities;
using DAL.Helpers;

namespace Services.Services
{
	public interface ITransmissionService
	{
		List<Transmission> GetTrasmissions();

		SaveUpdateResult<Transmission> CreateTransmission(int gearBoxTypeId, int transmissionTypeId);
	}
}
