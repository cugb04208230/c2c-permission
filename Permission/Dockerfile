#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 56526
EXPOSE 44361

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY ["Permission/Permission.csproj", "Permission/"]
RUN dotnet restore "Permission/Permission.csproj"
COPY . .
WORKDIR "/src/Permission"
RUN dotnet build "Permission.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Permission.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Permission.dll"]