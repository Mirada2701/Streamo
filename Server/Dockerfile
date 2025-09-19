# Learn about building .NET container images:
# https://github.com/dotnet/dotnet-docker/blob/main/samples/README.md
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
WORKDIR /app

WORKDIR /src

COPY ["Streamo.Application/Streamo.Application.csproj", "Streamo.Application/"]
COPY ["Streamo.Domain/Streamo.Domain.csproj", "Streamo.Domain/"]
COPY ["Streamo.Persistence/Streamo.Persistence.csproj", "Streamo.Persistence/"]
COPY ["Streamo.WebApi/Streamo.WebApi.csproj", "Streamo.WebApi/"]
RUN dotnet restore "Streamo.WebApi/Streamo.WebApi.csproj"

# copy everything else and build app
COPY . .
WORKDIR /src/Streamo.WebApi
RUN dotnet build "Streamo.WebApi.csproj" -c Release -o /app/build


FROM build AS publish
RUN dotnet publish "Streamo.WebApi.csproj" -c Release -o /app/publish


# final stage/image
#FROM mcr.microsoft.com/dotnet/aspnet:7.0
#WORKDIR /app
#COPY --from=build /app/publish .
#ENTRYPOINT ["dotnet", "Streamo.WebApi.dll"]

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Streamo.WebApi.dll"]
