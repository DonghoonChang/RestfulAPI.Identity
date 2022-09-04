#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RestfulAPI.Identity.Api/RestfulAPI.Identity.Api.csproj", "RestfulAPI.Identity.Api/"]
RUN dotnet restore "RestfulAPI.Identity.Api/RestfulAPI.Identity.Api.csproj"
COPY . .
WORKDIR "/src/RestfulAPI.Identity.Api"
RUN dotnet build "RestfulAPI.Identity.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RestfulAPI.Identity.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RestfulAPI.Identity.Api.dll"]