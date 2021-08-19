#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app


FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["MabyJewelrry/MabyJewelrry.csproj", "MabyJewelrry/"]
COPY ["MabyJewelrry.Utility/MabyJewelrry.Utility.csproj", "MabyJewelrry.Utility/"]
COPY ["MabyJewelrry.Model/MabyJewelrry.Model.csproj", "MabyJewelrry.Model/"]
COPY ["MabyJewelrry.DataAccess/MabyJewelrry.DataAccess.csproj", "MabyJewelrry.DataAccess/"]
RUN dotnet restore "MabyJewelrry/MabyJewelrry.csproj"
COPY . .
WORKDIR "/src/MabyJewelrry"
RUN dotnet build "MabyJewelrry.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MabyJewelrry.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MabyJewelrry.dll"]