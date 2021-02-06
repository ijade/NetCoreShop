@ECHO OFF
start cmd /k dotnet run -p ./API/Chatty.Api/Chatty.Api.csproj
cd ./client
npm start
PAUSE
