FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["RecrutoLetsBeFriends/RecrutoLetsBeFriends.csproj", "RecrutoLetsBeFriends/"]
RUN dotnet restore "RecrutoLetsBeFriends/RecrutoLetsBeFriends.csproj"
COPY . .
WORKDIR "/src/RecrutoLetsBeFriends"
RUN dotnet build "RecrutoLetsBeFriends.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "RecrutoLetsBeFriends.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RecrutoLetsBeFriends.dll"]
