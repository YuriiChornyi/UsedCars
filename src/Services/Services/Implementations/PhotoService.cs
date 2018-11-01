using System;
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
		public bool AddImages(IFormFileCollection files, Guid advertisementId)
		{
			CloudBlobContainer container = GetCloudBlobContainer();
			container.CreateIfNotExistsAsync();
			advertisementId=new Guid("972B709A-1640-4193-A30A-08D63F3560C3");
			
			foreach (var file in files)
			{
				CloudBlockBlob blob = container.GetBlockBlobReference(file.FileName);
				blob.UploadFromStreamAsync(file.OpenReadStream());
				_repository.Add(new Photo{AdvertisementId = advertisementId, PhotoURL = "https://usedcarsphoto.blob.core.windows.net/images/" + file.FileName });
			}

			return true;
		}

		private CloudBlobContainer GetCloudBlobContainer()
		{
			var storageCredentials = new StorageCredentials("usedcarsphoto", "PAYlebNMkHTIMs6ddx7/9VWXKxjpNpVOE66xMT88r2CFItUCZT9NXZbpWiuXsIdBO9lX3OSTMTD7vL19TjlepA==");
			var cloudStorageAccount = new CloudStorageAccount(storageCredentials, true);
			var cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();

			var container = cloudBlobClient.GetContainerReference("images");
			//CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
			//	CloudConfigurationManager.GetSetting("DefaultEndpointsProtocol=https;AccountName=usedcarsphoto;AccountKey=PAYlebNMkHTIMs6ddx7/9VWXKxjpNpVOE66xMT88r2CFItUCZT9NXZbpWiuXsIdBO9lX3OSTMTD7vL19TjlepA==;EndpointSuffix=core.windows.net"));
			//CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
			//CloudBlobContainer container = blobClient.GetContainerReference("images");
			return container;
		}
	}
}
