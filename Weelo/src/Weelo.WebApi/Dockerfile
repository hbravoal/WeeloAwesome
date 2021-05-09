#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Weelo.WebApi/Weelo.WebApi.csproj", "src/Weelo.WebApi/"]
RUN dotnet restore "src/Weelo.WebApi/Weelo.WebApi.csproj"
COPY . .
WORKDIR "/src/src/Weelo.WebApi"
RUN dotnet build "Weelo.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Weelo.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY ["src/Weelo.WebApi/Weelo.WebApi.xml", "/app"]
ENTRYPOINT ["dotnet", "Weelo.WebApi.dll"]