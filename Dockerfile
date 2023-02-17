# build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /source
COPY . .
RUN dotnet restore "./CBIInventoryAPI/CBIInventoryAPI.csproj" --disable-parallel
RUN dotnet publish "./CBIInventoryAPI/CBIInventoryAPI.csproj" -c release -o /app --no-restore

# serve stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal
WORKDIR /app
COPY --from=build /app ./

EXPOSE 5000
EXPOSE 7204
EXPOSE 5204

ENTRYPOINT ["dotnet", "CBIInventoryAPI.dll"]