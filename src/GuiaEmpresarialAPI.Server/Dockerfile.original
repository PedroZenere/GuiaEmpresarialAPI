#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/GuiaEmpresarialAPI.Server/GuiaEmpresarialAPI.Server.csproj", "src/GuiaEmpresarialAPI.Server/"]
RUN dotnet restore "src/GuiaEmpresarialAPI.Server/GuiaEmpresarialAPI.Server.csproj"
COPY . .
WORKDIR "/src/src/GuiaEmpresarialAPI.Server"
RUN dotnet build "GuiaEmpresarialAPI.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GuiaEmpresarialAPI.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GuiaEmpresarialAPI.Server.dll"]