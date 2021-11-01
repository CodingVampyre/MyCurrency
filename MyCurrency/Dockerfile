FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MyCurrency/MyCurrency.csproj", "MyCurrency/"]
RUN dotnet restore "MyCurrency/MyCurrency.csproj"
COPY . .
WORKDIR "/src/MyCurrency"
RUN dotnet build "MyCurrency.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyCurrency.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyCurrency.dll"]
