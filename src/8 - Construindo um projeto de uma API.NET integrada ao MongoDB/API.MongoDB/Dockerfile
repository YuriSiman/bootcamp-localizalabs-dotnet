#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["src/8 - Construindo um projeto de uma API.NET integrada ao MongoDB/API.MongoDB/API.MongoDB.csproj", "src/8 - Construindo um projeto de uma API.NET integrada ao MongoDB/API.MongoDB/"]
RUN dotnet restore "src/8 - Construindo um projeto de uma API.NET integrada ao MongoDB/API.MongoDB/API.MongoDB.csproj"
COPY . .
WORKDIR "/src/src/8 - Construindo um projeto de uma API.NET integrada ao MongoDB/API.MongoDB"
RUN dotnet build "API.MongoDB.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "API.MongoDB.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "API.MongoDB.dll"]