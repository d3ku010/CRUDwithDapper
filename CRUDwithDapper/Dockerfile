# Use the official .NET SDK image for building the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy only the necessary project files for restoring dependencies
COPY CRUDwithDapper/*.csproj ./
RUN dotnet restore

# Copy the rest of the application files and publish the app
COPY . ./
RUN dotnet publish -c Release -o /app/publish

# Use a runtime image for the final container
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

# Copy the published files from the build image
COPY --from=build /app/publish .

# Expose port 5000 for the application
EXPOSE 5000

# Run the application
ENTRYPOINT ["dotnet", "CRUDwithDapper.dll"]
