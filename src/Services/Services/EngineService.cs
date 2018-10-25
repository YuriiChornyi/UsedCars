using System.Collections.Generic;
using System.Linq;
using DAL;
using DAL.Entities;
using DAL.Helpers;

namespace Services.Services
{
	public class EngineService : IEngineService
	{
		private readonly IRepository<Engine> _engineRepository;
		private readonly IRepository<EngineType> _engineTypeRepository;

		public EngineService(IRepository<Engine> engineRepository, IRepository<EngineType> engineTypeRepository)
		{
			_engineRepository = engineRepository;
			_engineTypeRepository = engineTypeRepository;

		}

		public List<EngineType> GetEngineTypes()
		{
			return _engineTypeRepository.GetAll().ToList();
		}

		public SaveUpdateResult<Engine> CreateEngine(int engineTypeId, string value, int hp)
		{
			return _engineRepository.AddAsync(new Engine() {EngineTypeId = engineTypeId, Value = value, HP = hp});
		}
	}
}
