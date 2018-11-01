using System;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace UsedCars.Controllers
{
	[Route("[controller]/[action]")]
	[ApiController]
	public class PhotoController : ControllerBase
	{
		private readonly IPhotoService _service;
	
		public PhotoController(IPhotoService service)
		{
			_service = service;
		}

		[HttpPost, DisableRequestSizeLimit]
		public void AddPhotos(Guid advertisementId)
		{
			var files = Request.Form.Files;
			if (files.Count>0)
			{
				_service.AddImages(files, new Guid());
			}

		}
	}
}