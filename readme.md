![Logo](simplefx-logo.png)
# SimpleFX REST API client

This is a C# implementation of the SimpleFX REST API, automatically generated via [OpenAPI generator](https://openapi-generator.tech/) found here:

https://simplefx.com/docs/api/swagger

### License: 
    Apache License 2.0


### Generator usage

Linux/mac:
    wget http://central.maven.org/maven2/org/openapitools/openapi-generator-cli/4.2.2/openapi-generator-cli-4.2.2.jar -O openapi-generator-cli.jar

Windows:
    Invoke-WebRequest -OutFile openapi-generator-cli.jar http://central.maven.org/maven2/org/openapitools/openapi-generator-cli/4.2.2/openapi-generator-cli-4.2.2.jar


java -jar openapi-generator-cli.jar list
java -jar openapi-generator-cli.jar generate -g csharp-netcore -o generated -i simplefx.json -c generator-config.json --skip-validate-spec

