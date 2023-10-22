FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build-env

WORKDIR /pizaaweb

COPY ["pizaaweb.csproj", "."]

# # Restore as distinct layers
RUN dotnet restore "pizaaweb.csproj"
COPY . .

# Build and publish a release
RUN dotnet build "pizaaweb.csproj" -c Release -o out
RUN dotnet publish "pizaaweb.csproj" -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine
WORKDIR /pizaaweb
COPY --from=build-env /pizaaweb/out .

EXPOSE 80

ENTRYPOINT ["dotnet", "pizaaweb.dll"]