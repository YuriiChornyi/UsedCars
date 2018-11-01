using Microsoft.AspNetCore.Http;
using System;

namespace Services.Services
{
	public interface IPhotoService
	{
		bool AddImages(IFormFileCollection files, Guid advertisementId);
	}
}
