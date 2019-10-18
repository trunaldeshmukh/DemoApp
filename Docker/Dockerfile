FROM microsoft/dotnet:2.1-aspnetcore-runtime

COPY publish /app/publish
WORKDIR /app

ENTRYPOINT ["dotnet", "publish/DemoApp.dll"]
