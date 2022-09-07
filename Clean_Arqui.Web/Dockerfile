#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Clean_Arqui.Web/Clean_Arqui.Web.csproj", "Clean_Arqui.Web/"]
RUN dotnet restore "Clean_Arqui.Web/Clean_Arqui.Web.csproj"
COPY . .
WORKDIR "/src/Clean_Arqui.Web"
RUN dotnet build "Clean_Arqui.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Clean_Arqui.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Clean_Arqui.Web.dll"]