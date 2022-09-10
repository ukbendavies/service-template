# Service Template

A template repository for developing new services from an Open API specification. Includes code generation, a domain driven design architecture and CI/CD with GitHub actions.

Start the Swagger Viewer.

```sh
docker compose -f swagger.docker-compose.yaml up -d
```

Start the mock server.

```sh
prism mock petstore.oas3.json
```