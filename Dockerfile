FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

COPY . ./
# Restore as distinct layers
RUN dotnet restore Template.Server.sln
# Build and publish a release
RUN dotnet publish Template.Server.sln -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "Template.Presentation.dll"]