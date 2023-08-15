#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0-preview AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 7000

FROM mcr.microsoft.com/dotnet/sdk:8.0-preview AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Albazon.Services.Discounts.Api/Albazon.Services.Discounts.Api.csproj", "src/Albazon.Services.Discounts.Api/"]
RUN dotnet restore "src/Albazon.Services.Discounts.Api/Albazon.Services.Discounts.Api.csproj"
COPY . .
WORKDIR "/src/src/Albazon.Services.Discounts.Api"
RUN dotnet build "Albazon.Services.Discounts.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
RUN dotnet publish "Albazon.Services.Discounts.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Albazon.Services.Discounts.Api.dll"]