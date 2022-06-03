#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS restore
WORKDIR /app


# #COPY ["CalculatorXunitTest.csproj", ""]
# #RUN dotnet restore "CalculatorXunitTest.csproj"
COPY "*.csproj" "./"
RUN dotnet restore
COPY "." "./"
RUN rm -rf "./TestResults"

# #Build
# #RUN dotnet build "CalculatorXunitTest.csproj"
RUN dotnet build -c Release

# # run the unit tests
FROM restore AS test
# #RUN dotnet test "CalculatorXunitTest.csproj" -c Release --logger:trx
RUN dotnet test -c Release --logger:trx
# #RUN dotnet test --logger:trx -c Release --no-build

FROM scratch as export-test-results
COPY --from=test /app/TestResults/*.trx .

# # publish the API
# #FROM build AS publish
# #WORKDIR /app/publish
# #RUN dotnet publish "CalculatorXunitTest.csproj" -c Release -o /app/build

# #
# #WORKDIR "/src/CalculatorXunitTest"
# #RUN dotnet test
# #RUN dotnet build "CalculatorXunitTest.csproj" -c Release -o /app/build

# #
# #FROM build AS publish
# #RUN dotnet publish "CalculatorXunitTest.csproj" -c Release -o /app/publish
# #RUN dotnet publish -c Release --no-build -o /app/publish

# #FROM base AS final
# #WORKDIR /app
# #COPY --from=publish /app/publish .
# #ENTRYPOINT ["dotnet", "CalculatorXunitTest.dll"]


# #para fazer o build deste dockerfile
# #docker build -f .\Dockerfile -t test .

# #para exportar o resultado do teste do docker para fora do container
# #docker build --target export-test-results --output type=local,dest="C:\jenkins\SpecFlowCalculatorMVCNew\CalculatorXunitTest" .

# #para acessar o container e ver os arquivos internos/gerados
# #docker run -it --rm --name test123 test

# #para limpar o cache do docker image / docker build
# #docker builder prune