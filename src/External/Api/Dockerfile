FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 5000
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Directory.Packages.props", "."]
COPY ["Directory.Build.props", "."]
COPY ["src/Core/Application/MyCompany.MyProduct.Application.csproj", "src/Core/Application/"]
COPY ["src/Core/Domain/MyCompany.MyProduct.Domain.csproj", "src/Core/Domain/"]
COPY ["src/External/Api/MyCompany.MyProduct.Api.csproj", "src/External/Api/"]
COPY ["src/External/Infrastructure/MyCompany.MyProduct.Infrastructure.csproj", "src/External/Infrastructure/"]
COPY ["src/External/Persistence/MyCompany.MyProduct.Persistence.csproj", "src/External/Persistence/"]
RUN dotnet restore "./src/External/Api/./MyCompany.MyProduct.Api.csproj"
COPY . .
WORKDIR "/src/src/External/Api"
RUN dotnet build "./MyCompany.MyProduct.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./MyCompany.MyProduct.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyCompany.MyProduct.Api.dll"]