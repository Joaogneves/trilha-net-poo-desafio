FROM mcr.microsoft.com/dotnet/sdk:6.0

WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./

RUN dotnet build DesafioPOO.csproj -c Release -o out

CMD ["dotnet", "run"]
