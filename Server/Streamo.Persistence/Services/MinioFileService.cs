using Streamo.Application.Common.Interfaces;
using Streamo.Application.Common.Models;
using Minio;
using Minio.DataModel.Args;
using Minio.Exceptions;
using SixLabors.ImageSharp.Formats.Webp;

namespace Streamo.Persistence.Services
{
    public class MinioFileService : IFileService
    {
        private readonly IMinioClient minioClient;

        public MinioFileService(IMinioClient minioClient)
        {
            this.minioClient = minioClient;
        }

        public async Task<(Result Result, string Url)> GetFileUrlAsync(string bucket, string fileId, string contentType)
        {
            var argsGetUrl = new PresignedGetObjectArgs()
                .WithBucket(bucket)
                .WithObject(fileId)
                .WithHeaders(new Dictionary<string, string> {
                    { "response-content-type", contentType },
                })
                .WithExpiry(7 * 24 * 3600);
            var url = await minioClient.PresignedGetObjectAsync(argsGetUrl);
            return (Result.Success(), url);
        }

        public async Task<(Result Result, string? FileId)> UploadFileAsync(string bucket, Stream source)
        {

            var videoName = Guid.NewGuid().ToString();
            string root = Directory.GetCurrentDirectory();
            string videoPath = Path.Combine(root, "videos", videoName);

            using (FileStream fileStream = File.Create(videoPath + ".mp4"))
            {
                // Copy data from the source stream to the file stream
                source.CopyTo(fileStream);
            }

            return (Result.Success(), videoName);

            //return await UploadFileAsync(bucket, source, Guid.NewGuid().ToString());
        }

        public async Task<(Result Result, string? FileId)> UploadFileAsync(string bucket, Stream source, string filename)
        {
            var videoName = Guid.NewGuid().ToString();
            string root = Directory.GetCurrentDirectory();
            string imagePath = Path.Combine(root, "videos", videoName);
            string oldVideoPath = Path.Combine(root, "videos", filename)+".mp4";
            if(File.Exists(oldVideoPath))
            {
                File.Delete(oldVideoPath);
            }
            

            using (FileStream fileStream = File.Create(imagePath + ".mp4"))
            {
                // Copy data from the source stream to the file stream
                source.CopyTo(fileStream);
            }

            return (Result.Success(), videoName);
        }


        public async Task DeleteFileAsync(string bucket, string filename)
        {
            string root = Directory.GetCurrentDirectory();
            string oldVideoPath = Path.Combine(root, "videos", filename) + ".mp4";
            if (File.Exists(oldVideoPath))
            {
                File.Delete(oldVideoPath);
            }
        }

        public async Task<bool> IsFileExistsAsync(string bucket, string filename)
        {

            string root = Directory.GetCurrentDirectory();
            string imagePath = Path.Combine(root, "videos", filename);
            return File.Exists(imagePath + ".mp4");

        }
    }
}
