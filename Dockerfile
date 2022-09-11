FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PersistentService/PersistentService.csproj", "PersistentService/"]
RUN dotnet restore "PersistentService/PersistentService.csproj"
COPY . .
WORKDIR "/src/PersistentService"
RUN dotnet build "PersistentService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PersistentService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PersistentService.dll"]
