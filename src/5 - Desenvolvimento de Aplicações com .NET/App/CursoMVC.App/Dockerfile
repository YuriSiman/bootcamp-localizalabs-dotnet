#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["src/5 - Desenvolvimento de Aplicações com .NET/App/CursoMVC.App/CursoMVC.App.csproj", "src/5 - Desenvolvimento de Aplicações com .NET/App/CursoMVC.App/"]
RUN dotnet restore "src/5 - Desenvolvimento de Aplicações com .NET/App/CursoMVC.App/CursoMVC.App.csproj"
COPY . .
WORKDIR "/src/src/5 - Desenvolvimento de Aplicações com .NET/App/CursoMVC.App"
RUN dotnet build "CursoMVC.App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CursoMVC.App.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CursoMVC.App.dll"]