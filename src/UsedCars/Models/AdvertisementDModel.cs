using System;
using System.Collections.Generic;

namespace UsedCars.Models
{
	public class AdvertisementDModel
	{
		public string CarManufacturer { get; set; }
		public string CarModel { get; set; }
		public DateTime ProductionYear { get; set; }
		public string Price { get; set; }
		public string VinCode { get; set; }
		public string Transmission { get; set; }
		public string Engine { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public List<PhotoModel> Photos { get; set; }
	}
}
