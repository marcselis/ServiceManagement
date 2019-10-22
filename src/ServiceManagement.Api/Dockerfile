FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Api/ServiceManagement.Api/ServiceManagement.Api.csproj", "Api/ServiceManagement.Api/"]
RUN dotnet restore "Api/ServiceManagement.Api/ServiceManagement.Api.csproj"
COPY . .
WORKDIR "/src/Api/ServiceManagement.Api"
RUN dotnet build "ServiceManagement.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ServiceManagement.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ServiceManagement.Api.dll"]