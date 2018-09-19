namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Create properties for a linked server</summary>
    public partial class RedisLinkedServerCreateProperties
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
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Sample.API.Models.IRedisLinkedServerCreateProperties.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IRedisLinkedServerCreateProperties.</returns>
        public static Sample.API.Models.IRedisLinkedServerCreateProperties FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new RedisLinkedServerCreateProperties(json) : null;
        }
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="RedisLinkedServerCreateProperties" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal RedisLinkedServerCreateProperties(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _linkedRedisCacheId = If( json?.PropertyT<Carbon.Json.JsonString>("linkedRedisCacheId"), out var __jsonLinkedRedisCacheId) ? (string)__jsonLinkedRedisCacheId : (string)LinkedRedisCacheId;
            _linkedRedisCacheLocation = If( json?.PropertyT<Carbon.Json.JsonString>("linkedRedisCacheLocation"), out var __jsonLinkedRedisCacheLocation) ? (string)__jsonLinkedRedisCacheLocation : (string)LinkedRedisCacheLocation;
            _serverRole = If( json?.PropertyT<Carbon.Json.JsonString>("serverRole"), out var __jsonServerRole) ? (string)__jsonServerRole : (string)ServerRole;
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="RedisLinkedServerCreateProperties" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="RedisLinkedServerCreateProperties" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            AddIf( null != LinkedRedisCacheId ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(LinkedRedisCacheId) : null, "linkedRedisCacheId" ,container.Add );
            AddIf( null != LinkedRedisCacheLocation ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(LinkedRedisCacheLocation) : null, "linkedRedisCacheLocation" ,container.Add );
            AddIf( null != ServerRole ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(ServerRole) : null, "serverRole" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}