using System.Collections.Generic;
using DAL.Entities;
using DAL.Helpers;

namespace Services.Services
{
	public interface IEngineService
	{
		List<Engine> GetEngines();

		SaveUpdateResult<Engine> CreateEngine(int engineTypeId, string value, int hp);
	}
}
