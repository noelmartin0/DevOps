FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["HelloWorld.csproj", "./"]
RUN dotnet restore "./HelloWorld.csproj"
COPY . .
RUN dotnet publish "HelloWorld.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
EXPOSE 5000
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "HelloWorld.dll"]