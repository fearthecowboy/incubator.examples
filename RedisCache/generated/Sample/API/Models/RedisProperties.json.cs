namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Properties of the redis cache.</summary>
    public partial class RedisProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        partial void AfterFromJson(Carbon.Json.JsonObject json);
        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Carbon.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        partial void AfterToJson(ref Carbon.Json.JsonObject container);
        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeFromJson(Carbon.Json.JsonObject json, ref bool returnNow);
        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeToJson(ref Carbon.Json.JsonObject container, ref bool returnNow);
        /// <summary>
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Sample.API.Models.IRedisProperties.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IRedisProperties.</returns>
        public static Sample.API.Models.IRedisProperties FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new RedisProperties(json) : null;
        }
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="RedisProperties" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal RedisProperties(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _redisCreateProperties = new Sample.API.Models.RedisCreateProperties(json);
            _accessKeys = If( json?.PropertyT<Carbon.Json.JsonObject>("accessKeys"), out var __jsonAccessKeys) ? Sample.API.Models.RedisAccessKeys.FromJson(__jsonAccessKeys) : AccessKeys;
            _hostName = If( json?.PropertyT<Carbon.Json.JsonString>("hostName"), out var __jsonHostName) ? (string)__jsonHostName : (string)HostName;
            _linkedServers = If( json?.PropertyT<Carbon.Json.JsonArray>("linkedServers"), out var __jsonLinkedServers) ? If( __jsonLinkedServers, out var __w) ? new System.Func<Sample.API.Models.IRedisLinkedServer[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __w, (__v)=> Sample.API.Models.RedisLinkedServer.FromJson(__v)  ) ) )() : null : LinkedServers;
            _port = If( json?.PropertyT<Carbon.Json.JsonNumber>("port"), out var __jsonPort) ? (int?)__jsonPort : Port;
            _provisioningState = If( json?.PropertyT<Carbon.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;
            _redisVersion = If( json?.PropertyT<Carbon.Json.JsonString>("redisVersion"), out var __jsonRedisVersion) ? (string)__jsonRedisVersion : (string)RedisVersion;
            _sslPort = If( json?.PropertyT<Carbon.Json.JsonNumber>("sslPort"), out var __jsonSslPort) ? (int?)__jsonSslPort : SslPort;
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="RedisProperties" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="RedisProperties" /> as a <see cref="Carbon.Json.JsonNode" />.
        /// </returns>
        public Carbon.Json.JsonNode ToJson(Carbon.Json.JsonObject container, Microsoft.Rest.ClientRuntime.SerializationMode serializationMode)
        {
            container = container ?? new Carbon.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            _redisCreateProperties?.ToJson(container, serializationMode);
            AddIf( null != AccessKeys ? (Carbon.Json.JsonNode) AccessKeys.ToJson(null) : null, "accessKeys" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Rest.ClientRuntime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != HostName ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(HostName) : null, "hostName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Rest.ClientRuntime.SerializationMode.IncludeReadOnly))
            {
                if (null != LinkedServers)
                {
                    var __x = new Carbon.Json.XNodeArray();
                    foreach( var __y in LinkedServers )
                    {
                        AddIf(__y?.ToJson(null) ,__x.Add);
                    }
                    container.Add("linkedServers",__x);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Rest.ClientRuntime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != Port ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((int)Port) : null, "port" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Rest.ClientRuntime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != ProvisioningState ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(ProvisioningState) : null, "provisioningState" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Rest.ClientRuntime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != RedisVersion ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(RedisVersion) : null, "redisVersion" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Rest.ClientRuntime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != SslPort ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((int)SslPort) : null, "sslPort" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}