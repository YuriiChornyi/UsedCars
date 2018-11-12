using System.Threading.Tasks;
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
		public async Task<IActionResult> AddPhotos(string description)
		{
			var files = Request.Form.Files;

			if (files.Count > 0)
			{
				var res = await _service.AddImages(files);
				return new JsonResult(res);
			}

			return NoContent();
		}
	}
}