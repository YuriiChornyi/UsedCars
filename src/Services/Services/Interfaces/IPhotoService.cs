using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Services.Services
{
	public interface IPhotoService
	{
		Task<string> AddImages(IFormFileCollection files);
	}
}
