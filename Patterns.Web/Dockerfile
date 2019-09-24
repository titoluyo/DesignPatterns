FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-alpine AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-alpine AS build
WORKDIR /src
COPY ["Patterns.Web/Patterns.Web.csproj", "Patterns.Web/"]
RUN dotnet restore "Patterns.Web/Patterns.Web.csproj"
COPY . .
WORKDIR "/src/Patterns.Web"
RUN dotnet build "Patterns.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Patterns.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Patterns.Web.dll"]