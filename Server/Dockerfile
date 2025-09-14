# Learn about building .NET container images:
# https://github.com/dotnet/dotnet-docker/blob/main/samples/README.md
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
WORKDIR /app

WORKDIR /src

COPY ["MEGUTube.Application/MEGUTube.Application.csproj", "MEGUTube.Application/"]
COPY ["MEGUTube.Domain/MEGUTube.Domain.csproj", "MEGUTube.Domain/"]
COPY ["MEGUTube.Persistence/MEGUTube.Persistence.csproj", "MEGUTube.Persistence/"]
COPY ["MEGUTube.WebApi/MEGUTube.WebApi.csproj", "MEGUTube.WebApi/"]
RUN dotnet restore "MEGUTube.WebApi/MEGUTube.WebApi.csproj"

# copy everything else and build app
COPY . .
WORKDIR /src/MEGUTube.WebApi
RUN dotnet build "MEGUTube.WebApi.csproj" -c Release -o /app/build


FROM build AS publish
RUN dotnet publish "MEGUTube.WebApi.csproj" -c Release -o /app/publish


# final stage/image
#FROM mcr.microsoft.com/dotnet/aspnet:7.0
#WORKDIR /app
#COPY --from=build /app/publish .
#ENTRYPOINT ["dotnet", "MEGUTube.WebApi.dll"]

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MEGUTube.WebApi.dll"]
