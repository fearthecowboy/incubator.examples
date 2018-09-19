namespace Times.Wire.Search.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    public partial class ArticlesListBySource200ApplicationJson
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
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="ArticlesListBySource200ApplicationJson" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal ArticlesListBySource200ApplicationJson(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _copyright = If( json?.PropertyT<Carbon.Json.JsonString>("copyright"), out var __jsonCopyright) ? (string)__jsonCopyright : (string)Copyright;
            _numResults = If( json?.PropertyT<Carbon.Json.JsonNumber>("num_results"), out var __jsonNumResults) ? (int?)__jsonNumResults : NumResults;
            _results = If( json?.PropertyT<Carbon.Json.JsonArray>("results"), out var __jsonResults) ? If( __jsonResults, out var __w) ? new System.Func<Times.Wire.Search.Models.IArticle[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __w, (__v)=> Times.Wire.Search.Models.Article.FromJson(__v)  ) ) )() : null : Results;
            _status = If( json?.PropertyT<Carbon.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)Status;
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Times.Wire.Search.Models.IArticlesListBySource200ApplicationJson.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Times.Wire.Search.Models.IArticlesListBySource200ApplicationJson.
        /// </returns>
        public static Times.Wire.Search.Models.IArticlesListBySource200ApplicationJson FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new ArticlesListBySource200ApplicationJson(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ArticlesListBySource200ApplicationJson" /> into a <see cref="Carbon.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ArticlesListBySource200ApplicationJson" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            AddIf( null != Copyright ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Copyright) : null, "copyright" ,container.Add );
            AddIf( null != NumResults ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((int)NumResults) : null, "num_results" ,container.Add );
            if (null != Results)
            {
                var __x = new Carbon.Json.XNodeArray();
                foreach( var __y in Results )
                {
                    AddIf(__y?.ToJson(null) ,__x.Add);
                }
                container.Add("results",__x);
            }
            AddIf( null != Status ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Status) : null, "status" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}