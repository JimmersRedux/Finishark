ARG DOTNET_VERSION=10.0
ARG BUILD_CONFIGURATION=Release

FROM mcr.microsoft.com/dotnet/sdk:${DOTNET_VERSION} AS build

WORKDIR /src

COPY ["api.csproj", "./"]
RUN dotnet restore "./api.csproj"

COPY . .
RUN dotnet publish "./api.csproj" -c "$BUILD_CONFIGURATION" -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:${DOTNET_VERSION} AS run

WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "api.dll"]