#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MailSystem/MailSystem.csproj", "MailSystem/"]
COPY ["MailSystem.Data/MailSystem.Data.csproj", "MailSystem.Data/"]
COPY ["MailSystem.Domain/MailSystem.Domain.csproj", "MailSystem.Domain/"]
RUN dotnet restore "MailSystem/MailSystem.csproj"
COPY . .
WORKDIR "/src/MailSystem"
RUN dotnet build "MailSystem.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MailSystem.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MailSystem.dll"]