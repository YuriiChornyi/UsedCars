using System;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;

namespace Services.Services
{
	public class PhotoService : IPhotoService
	{
		private readonly IRepository<Photo> _repository;
		public PhotoService(IRepository<Photo> repo)
		{
			_repository = repo;
		}
		public async Task<string> AddImages(IFormFileCollection files)
		{
			CloudBlobContainer container = GetCloudBlobContainer();
			await container.CreateIfNotExistsAsync();

			var photoName = "";

			foreach (var file in files)
			{
				photoName = Guid.NewGuid() + "." + file.FileName.Split('.')[1];
				CloudBlockBlob blob = container.GetBlockBlobReference(photoName);
				await blob.UploadFromStreamAsync(file.OpenReadStream());
			}

			return photoName;
		}

		private CloudBlobContainer GetCloudBlobContainer()
		{
			var storageCredentials = new StorageCredentials("usedcarsphoto", "PAYlebNMkHTIMs6ddx7/9VWXKxjpNpVOE66xMT88r2CFItUCZT9NXZbpWiuXsIdBO9lX3OSTMTD7vL19TjlepA==");
			var cloudStorageAccount = new CloudStorageAccount(storageCredentials, true);
			var cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();

			var container = cloudBlobClient.GetContainerReference("images");
			return container;
		}
	}
}
