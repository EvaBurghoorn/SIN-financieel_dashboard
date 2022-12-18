FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build 
WORKDIR /build
COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o /financieel_dashboard

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime 
WORKDIR /financieel_dashboard
COPY --from=build /financieel_dashboard .
ENTRYPOINT ["dotnet", "Case_study.dll"]