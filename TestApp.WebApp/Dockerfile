FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["TestApp.WebApp/TestApp.WebApp.csproj", "TestApp.WebApp/"]
RUN dotnet restore "TestApp.WebApp/TestApp.WebApp.csproj"
COPY . .
WORKDIR "/src/TestApp.WebApp"
RUN dotnet build "TestApp.WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestApp.WebApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestApp.WebApp.dll"]
