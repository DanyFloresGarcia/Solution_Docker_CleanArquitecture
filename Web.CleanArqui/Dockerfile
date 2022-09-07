#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Web.CleanArqui/Web.CleanArqui.csproj", "Web.CleanArqui/"]
RUN dotnet restore "Web.CleanArqui/Web.CleanArqui.csproj"
COPY . .
WORKDIR "/src/Web.CleanArqui"
RUN dotnet build "Web.CleanArqui.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Web.CleanArqui.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Web.CleanArqui.dll"]