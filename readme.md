![Logo](simplefx-logo.png)
# SimpleFX REST API client [![Build Status](https://travis-ci.com/Marfusios/simplefx-client-rest.svg?branch=master)](https://travis-ci.org/Marfusios/simplefx-client-rest) [![NuGet version](https://badge.fury.io/nu/SimpleFx.Client.Rest.Generated.svg)](https://badge.fury.io/nu/SimpleFx.Client.Rest.Generated)

This is a C# implementation of the SimpleFX REST API, automatically generated via [OpenAPI generator](https://openapi-generator.tech/) found here:

https://simplefx.com/docs/api/swagger

### License: 
    Apache License 2.0


### Generator usage

* Linux/mac:
    * `wget http://central.maven.org/maven2/org/openapitools/openapi-generator-cli/4.2.2/openapi-generator-cli-4.2.2.jar -O openapi-generator-cli.jar`

* Windows:
    * `Invoke-WebRequest -OutFile openapi-generator-cli.jar http://central.maven.org/maven2/org/openapitools/openapi-generator-cli/4.2.2/openapi-generator-cli-4.2.2.jar`

* Command:
    * `java -jar openapi-generator-cli.jar generate -g csharp-netcore -o generated -i simplefx.json -c generator-config.json --skip-validate-spec`

### Usage example

[Program.cs](src/SimpleFx.Client.Rest.Sample/Program.cs)
