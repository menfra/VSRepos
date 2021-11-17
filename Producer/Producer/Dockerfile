#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

## syntax=docker/dockerfile:1
#FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
#WORKDIR /app
#
## Copy csproj and restore as distinct layers
#COPY *.csproj ./
#RUN dotnet restore
#
## Copy everything else and build
#COPY . .
#RUN dotnet publish -c Release -o out
#
## Build runtime image
#FROM mcr.microsoft.com/dotnet/aspnet:3.1
#WORKDIR /app
#COPY --from=build-env /app/out .
#ENTRYPOINT ["dotnet", "Producer.dll"]

FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

# Creates a non-root user with an explicit UID and adds permission to access the /app folder
# For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Producer.csproj", "./"]
RUN dotnet restore "Producer.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Producer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Producer.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Producer.dll"]

