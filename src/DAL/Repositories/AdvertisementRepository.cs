using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DAL.Entities;
using DAL.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using AdvertisementD = DAL.DapperEntities.Advertisement;

namespace DAL.Repositories
{
	public class AdvertisementRepository : IAdvertisementRepository
	{
		/// <summary>
		/// The database context
		/// </summary>
		private readonly UsedCarsDbContext _dbContext;

		/// <summary>
		/// Initializes a new instance of the <see cref="AdvertisementRepository"/> class.
		/// </summary>
		public AdvertisementRepository(UsedCarsDbContext context)
		{
			_dbContext = context;
		}

		public Advertisement GetById(int id)
		{
			throw new NotImplementedException();
		}

		public void Add(Advertisement item)
		{
			throw new NotImplementedException();
		}

		public SaveUpdateResult<Advertisement> AddAsync(Advertisement item)
		{
			item.UserId = new Guid("43d7bb9f-157a-430b-b3b9-08d639a81cdd");
			var result = _dbContext.Advertisement.AddAsync(item).Result.Entity;
			var errorCode = _dbContext.SaveChanges() > 0 ? 1 : 2;
			return new SaveUpdateResult<Advertisement> {Result = result, ErrorCode = (ErrorCodeExtended) errorCode};
		}

		public Task<Advertisement> Get(Guid id)
		{
			throw new NotImplementedException();
		}

		public IQueryable<Advertisement> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<Advertisement> GetByGuid(Guid id)
		{
			throw new NotImplementedException();
		}

		public void Remove(Guid id)
		{
			throw new NotImplementedException();
		}

		public ListDto<AdvertisementD> GetAdvertisementsPaged(int offset, int pageSize)
		{
			var list = new ListDto<AdvertisementD>();

			var sqlQueryItems =
				@"select man.ManufacturerName as CarManufacturer, carModel.CarModelName as CarModel, car.ProductionYear as ProductionYear,
			adv.Price as Price, car.VinCode as VinCode, gearBoxType.[Type] + ' ' + transmissionType.[Type] as Transmission,
			engineType.[Type] + ' ' + engine.[Value] + 'L. ' + CONVERT(VARCHAR(10), engine.HP) + 'hp' as Engine, 
			carUser.[Name] as UserName, carUser.Email as Email, carUser.Phone as Phone, photo.[PhotoName] as Photo
			from dbo.Car as car
				Left join  dbo.Advertisement as adv on car.AdvertisementId = adv.AdvertisementId
			left join dbo.Engine as engine on engine.EngineId = car.EngineId
			left join dbo.EngineType as engineType on engineType.EngineTypeId = engine.EngineTypeId
			left join dbo.Transmission as transmission on transmission.TransmissionId = car.TransmissionId
			left join dbo.GearBoxType as gearBoxType on gearBoxType.GearBoxTypeId = transmission.GearBoxTypeId
			left join dbo.TransmissionType as transmissionType on transmissionType.TransmissionTypeId = transmission.TransmissionTypeId
			left join dbo.CarModel as carModel on carModel.CarModelId = car.CarModelId
			left join dbo.Manufacturer as man on man.ManufacturerId = carModel.ManufacturerId
			left join dbo.[User] as carUser on carUser.UserId = adv.UserId
			left join dbo.[Photo] as photo on photo.AdvertisementId = adv.AdvertisementId
			ORDER BY CarManufacturer DESC
			OFFSET @offset ROWS
				FETCH NEXT @pageSize ROWS ONLY";
			var sqlQueryCount = @"select COUNT(AdvertisementId) FROM dbo.Advertisement";

			using (IDbConnection con = new SqlConnection(ConnectionStringHelper.Get()))
			{
				list.Items = con.Query<AdvertisementD>(sqlQueryItems, new { offset = offset, pageSize= pageSize });
				list.Count = con.ExecuteScalar<int>(sqlQueryCount);
			}

			return list;
		}

		public ListDto<Advertisement> GetLazyAdvertisementsPaged(int offset, int pageSize)
		{
			var  adv = _dbContext.Advertisement;
			return new ListDto<Advertisement>()
			{
				Count = _dbContext.Advertisement.Count(),
				Items = adv.Skip(offset).Take(pageSize).ToList()
			};
		}
	}
}