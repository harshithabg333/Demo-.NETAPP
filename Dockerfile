# --- Stage 1: build the app (uses the full .NET SDK, which is large) ---
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish
 
# --- Stage 2: run the app (uses the small .NET runtime only) ---
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "DemoApp.dll"]