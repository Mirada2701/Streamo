using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Ardalis.GuardClauses;
using Streamo.Persistence.Data.Contexts;
using Streamo.Persistence.Common.Extensions;
using Minio;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Streamo.Application.Common.Interfaces;
using Streamo.Persistence.Services;
using Streamo.Infrastructure.Services;
using Streamo.Persistence.Settings.Configurations;
using Streamo.Application.Common.DbContexts;
using IHttpClientFactory = Streamo.Application.Common.Interfaces.IHttpClientFactory;
using Streamo.Persistence.Services.EventPublishers;
using Microsoft.AspNetCore.SignalR;
using Streamo.Persistence.Data.Providers;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices {
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration) {
        // add options
        services.AddOptions<PhotoSettings>()
            .Bind(configuration.GetSection(nameof(PhotoSettings)))
            .ValidateDataAnnotations()
            .ValidateOnStart();

        var connectionString = configuration.GetConnectionString("DefaultConnection");
        //var connectionString = "Host=ep-little-shadow-ag2d88z0-pooler.c-2.eu-central-1.aws.neon.tech;Port=5432;Database=neondb;Username=neondb_owner;Password=npg_8KWmEX6sYOcM";

        // ensure that connection string exists, else throw startup exception
        Guard.Against.Null(connectionString, message: "Connection string 'DefaultConnection' not found.");

        services.AddDbContext<IApplicationDbContext, ApplicationDbContext>((sp, options) => {
            options.UseNpgsql(connectionString);
        });

        // setup Identity services
        services.AddIdentityExtensions(configuration)
            .AddEntityFrameworkStores<ApplicationDbContext>();

        // add http client
        services.AddHttpClient();

        // setup MinIO
        var minioHost = configuration.GetValue<string>("MinIO:Host");
        var minioAccessKey = configuration.GetValue<string>("MinIO:AccessKey");
        var minioSecretKey = configuration.GetValue<string>("MinIO:SecretKey");

        Guard.Against.Null(minioHost, message: "minioHost not found.");
        Guard.Against.Null(minioAccessKey, message: "minioAccessKey not found.");
        Guard.Against.Null(minioSecretKey, message: "minioAccessKey not found.");

        services.AddMinio(c => {
            c
            .WithEndpoint(minioHost)
            .WithCredentials(minioAccessKey, minioSecretKey)
            .WithSSL(true)
            .WithHttpClient(new HttpClient(new HttpClientHandler() {
                ServerCertificateCustomValidationCallback = (sender, certificate, chain, sslPolicyErrors) => {
                    // disable certificate verification (ONLY FOR DEV PURPOSE)
                    return true;
                }
            }))
            .Build();
        });
        services.TryAddScoped<IFileService, MinioFileService>();
        services.TryAddScoped<IPhotoService, PhotoService>();
        services.TryAddScoped<IVideoService, VideoService>();
        services.TryAddScoped<IMailService, MailService>();
        services.TryAddScoped<IDateTimeService, DateTimeService>();
        services.TryAddScoped<IHttpClientFactory, HttpClientFactory>();
        services.TryAddScoped<IAdminService, AdminService>();
        services.TryAddScoped<IVideoAccessModificatorService, VideoAccessModificatorService>();
        services.TryAddScoped<IEventPublisher, NotificationEventPublisher>();

        services.TryAddSingleton<IUserIdProvider, ApplicationUserIdProvider>();

        // setup SignalR
        services.AddSignalR();

        return services;
    }
}
