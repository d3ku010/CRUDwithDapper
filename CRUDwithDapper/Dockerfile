# Use the official .NET SDK image for building the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy the project files
COPY . ./

# Restore dependencies
RUN dotnet restore

# Build the app
RUN dotnet publish -c Release -o /app/publish

# Use a runtime image for the final container
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copy the published files
COPY --from=build /app/publish .

# Expose port 5000 for the application
EXPOSE 5000

# Run the application
ENTRYPOINT ["dotnet", "CRUDwithDapper.dll"]
