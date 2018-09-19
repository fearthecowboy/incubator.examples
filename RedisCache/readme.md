# Redis

> see https://aka.ms/autorest

This is the AutoRest configuration file for Redis.



---
## Getting Started
To build the SDK for Redis, simply [Install AutoRest](https://aka.ms/autorest/install) and in this folder, run:

> `autorest`

To see additional help and options, run:

> `autorest --help`
---

## Configuration


### Basic Information
These are the global settings for the Redis API.

``` yaml
use: "@microsoft.azure/autorest.incubator@preview"
openapi-type: arm
tag: package-2018-03
input-file: Microsoft.Cache/stable/2018-03-01/redis.json
llcsharp: 
  clear-output-folder: true
  output-folder: generated
```


## Suppression

``` yaml
directive:
  - suppress: R3006  # Model definition 'RedisResource' has extra properties ['zones']."
    where:
      - $.definitions.RedisResource.properties
    from: redis.json
    reason: zones properties will be allowed in subsequent version of the linter tool
  - suppress: R3018  # Booleans are not descriptive and make them hard to use. Consider using string enums with allowed set of values defined. Property: enableNonSslPort."
    where:
      - $.definitions.RedisCommonProperties.properties.enableNonSslPort
    from: redis.json
    reason: this will result in breaking change
  - suppress: R2017  # PUT request and response should be of same type "
    where:
      - $.paths["/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/Redis/{name}/linkedServers/{linkedServerName}"].put
      - $.paths["/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/Redis/{name}"].put
      - $.paths["/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/Redis/{cacheName}/firewallRules/{ruleName}"].put
    from: redis.json
    reason: bug from sdk team
  - suppress: R3010  # The child tracked resource, 'linkedServers' with immediate parent 'RedisResource', must have a list by immediate parent operation."
    where:
      - $.definitions
    from: redis.json
    reason: This is false positive, 'linkedServers' is not a tracked resource.
```