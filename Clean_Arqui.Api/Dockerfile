#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Clean_Arqui.Api/Clean_Arqui.Api.csproj", "Clean_Arqui.Api/"]
RUN dotnet restore "Clean_Arqui.Api/Clean_Arqui.Api.csproj"
COPY . .
WORKDIR "/src/Clean_Arqui.Api"
RUN dotnet build "Clean_Arqui.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Clean_Arqui.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Clean_Arqui.Api.dll"]