#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["m-mall-api/m-mall-api.csproj", "m-mall-api/"]
RUN dotnet restore "m-mall-api/m-mall-api.csproj"
COPY . .
WORKDIR "/src/m-mall-api"
RUN dotnet build "m-mall-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "m-mall-api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "m-mall-api.dll"]