namespace Times.Wire.Search.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    public partial class Article
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
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="Article" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal Article(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _abstract = If( json?.PropertyT<Carbon.Json.JsonString>("abstract"), out var __jsonAbstract) ? (string)__jsonAbstract : (string)Abstract;
            _blogName = If( json?.PropertyT<Carbon.Json.JsonString>("blog_name"), out var __jsonBlogName) ? (string)__jsonBlogName : (string)BlogName;
            _byline = If( json?.PropertyT<Carbon.Json.JsonString>("byline"), out var __jsonByline) ? (string)__jsonByline : (string)Byline;
            _createdDate = If( json?.PropertyT<Carbon.Json.JsonString>("created_date"), out var __jsonCreatedDate) ? (string)__jsonCreatedDate : (string)CreatedDate;
            _desFacet = If( json?.PropertyT<Carbon.Json.JsonArray>("des_facet"), out var __jsonDesFacet) ? If( __jsonDesFacet, out var __w) ? new System.Func<string[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __w, (__v)=> __v is Carbon.Json.JsonString __u ? (string)__u : null ) ) )() : null : DesFacet;
            _geoFacet = If( json?.PropertyT<Carbon.Json.JsonArray>("geo_facet"), out var __jsonGeoFacet) ? If( __jsonGeoFacet, out var __r) ? new System.Func<string[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __r, (__q)=> __q is Carbon.Json.JsonString __p ? (string)__p : null ) ) )() : null : GeoFacet;
            _headline = If( json?.PropertyT<Carbon.Json.JsonString>("headline"), out var __jsonHeadline) ? (string)__jsonHeadline : (string)Headline;
            _itemType = If( json?.PropertyT<Carbon.Json.JsonString>("item_type"), out var __jsonItemType) ? (string)__jsonItemType : (string)ItemType;
            _kicker = If( json?.PropertyT<Carbon.Json.JsonString>("kicker"), out var __jsonKicker) ? (string)__jsonKicker : (string)Kicker;
            _materialTypeFacet = If( json?.PropertyT<Carbon.Json.JsonString>("material_type_facet"), out var __jsonMaterialTypeFacet) ? (string)__jsonMaterialTypeFacet : (string)MaterialTypeFacet;
            _multimedia = If( json?.PropertyT<Carbon.Json.JsonArray>("multimedia"), out var __jsonMultimedia) ? If( __jsonMultimedia, out var __m) ? new System.Func<Times.Wire.Search.Models.IArticleMultimediaItemType[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __m, (__l)=> Times.Wire.Search.Models.ArticleMultimediaItemType.FromJson(__l)  ) ) )() : null : Multimedia;
            _orgFacet = If( json?.PropertyT<Carbon.Json.JsonString>("org_facet"), out var __jsonOrgFacet) ? (string)__jsonOrgFacet : (string)OrgFacet;
            _perFacet = If( json?.PropertyT<Carbon.Json.JsonArray>("per_facet"), out var __jsonPerFacet) ? If( __jsonPerFacet, out var __h) ? new System.Func<string[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __h, (__g)=> __g is Carbon.Json.JsonString __f ? (string)__f : null ) ) )() : null : PerFacet;
            _publishedDate = If( json?.PropertyT<Carbon.Json.JsonString>("published_date"), out var __jsonPublishedDate) ? (string)__jsonPublishedDate : (string)PublishedDate;
            _relatedUrls = If( json?.PropertyT<Carbon.Json.JsonArray>("related_urls"), out var __jsonRelatedUrls) ? If( __jsonRelatedUrls, out var __c) ? new System.Func<Times.Wire.Search.Models.IArticleRelatedUrlsItemType[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __c, (__b)=> Times.Wire.Search.Models.ArticleRelatedUrlsItemType.FromJson(__b)  ) ) )() : null : RelatedUrls;
            _section = If( json?.PropertyT<Carbon.Json.JsonString>("section"), out var __jsonSection) ? (string)__jsonSection : (string)Section;
            _shortUrl = If( json?.PropertyT<Carbon.Json.JsonString>("short_url"), out var __jsonShortUrl) ? (string)__jsonShortUrl : (string)ShortUrl;
            _source = If( json?.PropertyT<Carbon.Json.JsonString>("source"), out var __jsonSource) ? (string)__jsonSource : (string)Source;
            _subsection = If( json?.PropertyT<Carbon.Json.JsonString>("subsection"), out var __jsonSubsection) ? (string)__jsonSubsection : (string)Subsection;
            _thumbnailStandard = If( json?.PropertyT<Carbon.Json.JsonString>("thumbnail_standard"), out var __jsonThumbnailStandard) ? (string)__jsonThumbnailStandard : (string)ThumbnailStandard;
            _title = If( json?.PropertyT<Carbon.Json.JsonString>("title"), out var __jsonTitle) ? (string)__jsonTitle : (string)Title;
            _updatedDate = If( json?.PropertyT<Carbon.Json.JsonString>("updated_date"), out var __jsonUpdatedDate) ? (string)__jsonUpdatedDate : (string)UpdatedDate;
            _url = If( json?.PropertyT<Carbon.Json.JsonString>("url"), out var __jsonUrl) ? (string)__jsonUrl : (string)Url;
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Times.Wire.Search.Models.IArticle.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Times.Wire.Search.Models.IArticle.</returns>
        public static Times.Wire.Search.Models.IArticle FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new Article(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="Article" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Article" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            AddIf( null != Abstract ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Abstract) : null, "abstract" ,container.Add );
            AddIf( null != BlogName ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(BlogName) : null, "blog_name" ,container.Add );
            AddIf( null != Byline ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Byline) : null, "byline" ,container.Add );
            AddIf( null != CreatedDate ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(CreatedDate) : null, "created_date" ,container.Add );
            if (null != DesFacet)
            {
                var __x = new Carbon.Json.XNodeArray();
                foreach( var __y in DesFacet )
                {
                    AddIf(null != __y ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(__y) : null ,__x.Add);
                }
                container.Add("des_facet",__x);
            }
            if (null != GeoFacet)
            {
                var __s = new Carbon.Json.XNodeArray();
                foreach( var __t in GeoFacet )
                {
                    AddIf(null != __t ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(__t) : null ,__s.Add);
                }
                container.Add("geo_facet",__s);
            }
            AddIf( null != Headline ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Headline) : null, "headline" ,container.Add );
            AddIf( null != ItemType ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(ItemType) : null, "item_type" ,container.Add );
            AddIf( null != Kicker ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Kicker) : null, "kicker" ,container.Add );
            AddIf( null != MaterialTypeFacet ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(MaterialTypeFacet) : null, "material_type_facet" ,container.Add );
            if (null != Multimedia)
            {
                var __n = new Carbon.Json.XNodeArray();
                foreach( var __o in Multimedia )
                {
                    AddIf(__o?.ToJson(null) ,__n.Add);
                }
                container.Add("multimedia",__n);
            }
            AddIf( null != OrgFacet ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(OrgFacet) : null, "org_facet" ,container.Add );
            if (null != PerFacet)
            {
                var __i = new Carbon.Json.XNodeArray();
                foreach( var __j in PerFacet )
                {
                    AddIf(null != __j ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(__j) : null ,__i.Add);
                }
                container.Add("per_facet",__i);
            }
            AddIf( null != PublishedDate ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(PublishedDate) : null, "published_date" ,container.Add );
            if (null != RelatedUrls)
            {
                var __d = new Carbon.Json.XNodeArray();
                foreach( var __e in RelatedUrls )
                {
                    AddIf(__e?.ToJson(null) ,__d.Add);
                }
                container.Add("related_urls",__d);
            }
            AddIf( null != Section ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Section) : null, "section" ,container.Add );
            AddIf( null != ShortUrl ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(ShortUrl) : null, "short_url" ,container.Add );
            AddIf( null != Source ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Source) : null, "source" ,container.Add );
            AddIf( null != Subsection ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Subsection) : null, "subsection" ,container.Add );
            AddIf( null != ThumbnailStandard ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(ThumbnailStandard) : null, "thumbnail_standard" ,container.Add );
            AddIf( null != Title ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Title) : null, "title" ,container.Add );
            AddIf( null != UpdatedDate ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(UpdatedDate) : null, "updated_date" ,container.Add );
            AddIf( null != Url ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Url) : null, "url" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}