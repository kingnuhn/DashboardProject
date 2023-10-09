#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DashboardProject/Dashboard/Host/Dashboard.Host.Api/Dashboard.Host.Api/Dashboard.Host.Api.csproj", "DashboardProject/Dashboard/Host/Dashboard.Host.Api/Dashboard.Host.Api/"]
RUN dotnet restore "DashboardProject/Dashboard/Host/Dashboard.Host.Api/Dashboard.Host.Api/Dashboard.Host.Api.csproj"
COPY . .
WORKDIR "/src/DashboardProject/Dashboard/Host/Dashboard.Host.Api/Dashboard.Host.Api"
RUN dotnet build "Dashboard.Host.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Dashboard.Host.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dashboard.Host.Api.dll"]