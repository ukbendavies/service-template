# Contributing

When running on Codespaces `localhost` will not work, use the ports tab to open get the address. The addresses should be as follows `$CODESPACE_NAME-$PORT.githubpreview.dev.

Run the Swagger Viewer for interacting with the API on http://localhost:5000.

```sh
docker compose -f swagger.docker-compose.yaml up -d
```

Run a mock server on http://locahost:4010.

```sh
prism mock petstore.oas3.json
```

Generate the server code, this will use the configuration in `openapitools.json`.

```sh
openapi-generator-cli generate
```

Build the solution and run the Template Service. From Visual Studio Code you can run the 'Template Service' run configuration to run with the debugger.

```sh
dotnet build Template.sln
dotnet run --project Template.Presentation/Template.Presentation.csproj 
```

Try making a request to http://localhost:8080/v1/pets!

Instead of calling the API directly we can interact with using the generate client library, see [Template.Client.Demo](Template.Client.Demo/Program.cs). If the Template Service is running you can run the 'Template Client Demo' run configuration to try the demo application, or as follows from the command line.

```sh
cd Template.Client.Demo
dotnet run
```
