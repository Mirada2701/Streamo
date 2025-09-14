using Ardalis.GuardClauses;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.FileProviders;
using Microsoft.OpenApi.Models;
using MEGUTube.Application.Common.Mappings;
using MEGUTube.Infrastructure.Hubs;
using MEGUTube.Persistence.Data.Contexts;
using MEGUTube.Persistence.Data.Seeders;
using MEGUTube.WebApi.Swagger;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// get configuration
var configuration = builder.Configuration;

// Add Clean-Architecture layers
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(configuration);


//Configure limits
builder.Services.Configure<FormOptions>(options =>
{
    options.BufferBodyLengthLimit = int.MaxValue;
    options.MultipartBodyLengthLimit = int.MaxValue;
});
builder.Services.Configure<KestrelServerOptions>(options =>
{
    options.Limits.MaxRequestBodySize = int.MaxValue;
    options.Limits.MaxRequestBufferSize = int.MaxValue;
});

builder.Services.AddAutoMapper(config =>
{
    config.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly()));
    config.AddProfile(new AssemblyMappingProfile(typeof(ApplicationDbContext).Assembly));
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(o =>
{
    o.AddSecurityDefinition("Bearer",
        new OpenApiSecurityScheme
        {
            In = ParameterLocation.Header,
            Description = @"Bearer (paste here your token (remove all brackets) )",
            Name = "Authorization",
            Type = SecuritySchemeType.ApiKey,
            Scheme = "Bearer",
        });

    o.OperationFilter<AuthorizeCheckOperationFilter>();

    o.SwaggerDoc("v1", new OpenApiInfo()
    {
        Title = "MEGUTube API - v1",
        Version = "v1"
    });
});

// enable CORS to all sources
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
        policy.AllowAnyOrigin();
    });
});

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MEGUTube API - v1");

    // setup Google OAuth2
    var googleClientId = configuration.GetValue<string>("GoogleOAuth:ClientId");
    var googleClientSecret = configuration.GetValue<string>("GoogleOAuth:ClientSecret");
    var googleAppId = configuration.GetValue<string>("GoogleOAuth:AppId");

    Guard.Against.Null(googleClientId, message: "googleClientId not found.");
    Guard.Against.Null(googleClientSecret, message: "googleClientSecret not found.");
    Guard.Against.Null(googleAppId, message: "googleAppId not found.");

    // Specify the OAuth2 settings for Google Authentication
    c.OAuthClientId(googleClientId);
    c.OAuthClientSecret(googleClientSecret);
    c.OAuthAppName(googleAppId);
});
app.UseCors("AllowAll");

app.UseWebSockets();

var dir = Path.Combine(Directory.GetCurrentDirectory(), "photos");
if (!Directory.Exists(dir))
{
    Directory.CreateDirectory(dir);
}
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(dir),
    RequestPath = "/photos"
});

var dirVideos = Path.Combine(Directory.GetCurrentDirectory(), "videos");
if (!Directory.Exists(dirVideos))
{
    Directory.CreateDirectory(dirVideos);
}
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(dirVideos),
    RequestPath = "/videos"
});

//app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapHub<NotificationsHub>("/signalr/notifications");

app.SeedData();

app.Run();
