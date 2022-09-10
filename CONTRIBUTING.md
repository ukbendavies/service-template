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
