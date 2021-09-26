#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["NuGet.Config", "."]
COPY ["src/AbpDocker.Web/AbpDocker.Web.csproj", "src/AbpDocker.Web/"]
COPY ["src/AbpDocker.HttpApi/AbpDocker.HttpApi.csproj", "src/AbpDocker.HttpApi/"]
COPY ["src/AbpDocker.Application.Contracts/AbpDocker.Application.Contracts.csproj", "src/AbpDocker.Application.Contracts/"]
COPY ["src/AbpDocker.Domain.Shared/AbpDocker.Domain.Shared.csproj", "src/AbpDocker.Domain.Shared/"]
COPY ["src/AbpDocker.HttpApi.Client/AbpDocker.HttpApi.Client.csproj", "src/AbpDocker.HttpApi.Client/"]
RUN dotnet restore "src/AbpDocker.Web/AbpDocker.Web.csproj"
COPY . .
WORKDIR "/src/src/AbpDocker.Web"
RUN dotnet build "AbpDocker.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AbpDocker.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AbpDocker.Web.dll"]