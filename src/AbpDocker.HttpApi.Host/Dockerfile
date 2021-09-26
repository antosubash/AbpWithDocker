#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["NuGet.Config", "."]
COPY ["src/AbpDocker.HttpApi.Host/AbpDocker.HttpApi.Host.csproj", "src/AbpDocker.HttpApi.Host/"]
COPY ["src/AbpDocker.EntityFrameworkCore/AbpDocker.EntityFrameworkCore.csproj", "src/AbpDocker.EntityFrameworkCore/"]
COPY ["src/AbpDocker.Domain/AbpDocker.Domain.csproj", "src/AbpDocker.Domain/"]
COPY ["src/AbpDocker.Domain.Shared/AbpDocker.Domain.Shared.csproj", "src/AbpDocker.Domain.Shared/"]
COPY ["src/AbpDocker.HttpApi/AbpDocker.HttpApi.csproj", "src/AbpDocker.HttpApi/"]
COPY ["src/AbpDocker.Application.Contracts/AbpDocker.Application.Contracts.csproj", "src/AbpDocker.Application.Contracts/"]
COPY ["src/AbpDocker.Application/AbpDocker.Application.csproj", "src/AbpDocker.Application/"]
RUN dotnet restore "src/AbpDocker.HttpApi.Host/AbpDocker.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/src/AbpDocker.HttpApi.Host"
RUN dotnet build "AbpDocker.HttpApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AbpDocker.HttpApi.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AbpDocker.HttpApi.Host.dll"]