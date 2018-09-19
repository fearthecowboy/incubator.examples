namespace Xkcd.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    public partial class Comic
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
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="Comic" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal Comic(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _alt = If( json?.PropertyT<Carbon.Json.JsonString>("alt"), out var __jsonAlt) ? (string)__jsonAlt : (string)Alt;
            _day = If( json?.PropertyT<Carbon.Json.JsonString>("day"), out var __jsonDay) ? (string)__jsonDay : (string)Day;
            _img = If( json?.PropertyT<Carbon.Json.JsonString>("img"), out var __jsonImg) ? (string)__jsonImg : (string)Img;
            _link = If( json?.PropertyT<Carbon.Json.JsonString>("link"), out var __jsonLink) ? (string)__jsonLink : (string)Link;
            _month = If( json?.PropertyT<Carbon.Json.JsonString>("month"), out var __jsonMonth) ? (string)__jsonMonth : (string)Month;
            _news = If( json?.PropertyT<Carbon.Json.JsonString>("news"), out var __jsonNews) ? (string)__jsonNews : (string)News;
            _num = If( json?.PropertyT<Carbon.Json.JsonNumber>("num"), out var __jsonNum) ? (float?)__jsonNum : Num;
            _safeTitle = If( json?.PropertyT<Carbon.Json.JsonString>("safe_title"), out var __jsonSafeTitle) ? (string)__jsonSafeTitle : (string)SafeTitle;
            _title = If( json?.PropertyT<Carbon.Json.JsonString>("title"), out var __jsonTitle) ? (string)__jsonTitle : (string)Title;
            _transcript = If( json?.PropertyT<Carbon.Json.JsonString>("transcript"), out var __jsonTranscript) ? (string)__jsonTranscript : (string)Transcript;
            _year = If( json?.PropertyT<Carbon.Json.JsonString>("year"), out var __jsonYear) ? (string)__jsonYear : (string)Year;
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Xkcd.Models.IComic.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Xkcd.Models.IComic.</returns>
        public static Xkcd.Models.IComic FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new Comic(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="Comic" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Comic" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            AddIf( null != Alt ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Alt) : null, "alt" ,container.Add );
            AddIf( null != Day ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Day) : null, "day" ,container.Add );
            AddIf( null != Img ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Img) : null, "img" ,container.Add );
            AddIf( null != Link ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Link) : null, "link" ,container.Add );
            AddIf( null != Month ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Month) : null, "month" ,container.Add );
            AddIf( null != News ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(News) : null, "news" ,container.Add );
            AddIf( null != Num ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((float)Num) : null, "num" ,container.Add );
            AddIf( null != SafeTitle ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(SafeTitle) : null, "safe_title" ,container.Add );
            AddIf( null != Title ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Title) : null, "title" ,container.Add );
            AddIf( null != Transcript ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Transcript) : null, "transcript" ,container.Add );
            AddIf( null != Year ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Year) : null, "year" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}