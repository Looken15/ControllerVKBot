FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ControllerBot/ControllerBot.csproj", "ControllerBot/"]
RUN dotnet restore "ControllerBot/ControllerBot.csproj"
COPY . .
WORKDIR "/src/ControllerBot"
RUN dotnet build "ControllerBot.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ControllerBot.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=build src/ControllerBot/Migrations/Scripts ./Migrations/Scripts
ENTRYPOINT ["dotnet", "ControllerBot.dll"]

