FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["GameProject/GameProject.csproj", "GameProject/"]

RUN dotnet restore "GameProject/GameProject.csproj"
COPY . .
WORKDIR "/src/GameProject"
RUN dotnet build "GameProject.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GameProject.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GameProject.dll"]