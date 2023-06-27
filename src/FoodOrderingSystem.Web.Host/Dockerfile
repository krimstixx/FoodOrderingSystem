FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/FoodOrderingSystem.Web.Host/FoodOrderingSystem.Web.Host.csproj", "src/FoodOrderingSystem.Web.Host/"]
COPY ["src/FoodOrderingSystem.Web.Core/FoodOrderingSystem.Web.Core.csproj", "src/FoodOrderingSystem.Web.Core/"]
COPY ["src/FoodOrderingSystem.Application/FoodOrderingSystem.Application.csproj", "src/FoodOrderingSystem.Application/"]
COPY ["src/FoodOrderingSystem.Core/FoodOrderingSystem.Core.csproj", "src/FoodOrderingSystem.Core/"]
COPY ["src/FoodOrderingSystem.EntityFrameworkCore/FoodOrderingSystem.EntityFrameworkCore.csproj", "src/FoodOrderingSystem.EntityFrameworkCore/"]
WORKDIR "/src/src/FoodOrderingSystem.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/FoodOrderingSystem.Web.Host", "src/FoodOrderingSystem.Web.Host"]
COPY ["src/FoodOrderingSystem.Web.Core", "src/FoodOrderingSystem.Web.Core"]
COPY ["src/FoodOrderingSystem.Application", "src/FoodOrderingSystem.Application"]
COPY ["src/FoodOrderingSystem.Core", "src/FoodOrderingSystem.Core"]
COPY ["src/FoodOrderingSystem.EntityFrameworkCore", "src/FoodOrderingSystem.EntityFrameworkCore"]
WORKDIR "/src/src/FoodOrderingSystem.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "FoodOrderingSystem.Web.Host.dll"]
