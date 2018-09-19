namespace Times.Wire.Search
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Low-level API implementation for the Times Newswire service.
    /// </summary>
    public class TimesNewswire
    {

        /// <param name="url">The complete URL of a specific news item, URL-encoded or backslash-escaped</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Rest.ClientRuntime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task ArticlesList(string url, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Times.Wire.Search.Models.IArticlesList200ApplicationJson>, System.Threading.Tasks.Task> onOK, Microsoft.Rest.ClientRuntime.IEventListener eventListener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "http://api.nytimes.com/svc/news/v3//content.json"
                        + "?"
                        + "url=" + System.Uri.EscapeDataString(url)
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ArticlesList_Call(request,onOK,eventListener,sender);
            }
        }
        /// <param name="source">Limits the set of items by originating source
        /// all = items from both The New York Times and The International New York Times
        /// nyt = New York Times items only
        /// iht = International New York Times items only
        /// </param>
        /// <param name="section">Limits the set of items by one or more sections
        /// all | One or more section names, separated by semicolons
        /// To get all sections, specify all. To get a particular section or sections, use the section names returned by this request:
        /// http://api.nytimes.com/svc/news/v3/content/section-list.json
        /// </param>
        /// <param name="limit">Limits the number of results, between 1 and 20</param>
        /// <param name="offset">Sets the starting point of the result set</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Rest.ClientRuntime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task ArticlesListBySource(string source, string section, int? limit, int? offset, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Times.Wire.Search.Models.IArticlesListBySource200ApplicationJson>, System.Threading.Tasks.Task> onOK, Microsoft.Rest.ClientRuntime.IEventListener eventListener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "http://api.nytimes.com/svc/news/v3//content/"
                        + System.Uri.EscapeDataString(source)
                        + "/"
                        + System.Uri.EscapeDataString(section)
                        + ".json"
                        + "?"
                        + (null == limit ? System.String.Empty : "limit=" + System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == offset ? System.String.Empty : "offset=" + System.Uri.EscapeDataString(offset.ToString()))
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ArticlesListBySource_Call(request,onOK,eventListener,sender);
            }
        }
        /// <param name="source">Limits the set of items by originating source
        /// all = items from both The New York Times and The International New York Times
        /// nyt = New York Times items only
        /// iht = International New York Times items only
        /// </param>
        /// <param name="section">Limits the set of items by one or more sections
        /// all | One or more section names, separated by semicolons
        /// To get all sections, specify all. To get a particular section or sections, use the section names returned by this request:
        /// http://api.nytimes.com/svc/news/v3/content/section-list.json
        /// </param>
        /// <param name="timePeriod">Limits the set of items by time published, integer in number of hours</param>
        /// <param name="limit">Limits the number of results, between 1 and 20</param>
        /// <param name="offset">Sets the starting point of the result set</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Rest.ClientRuntime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task ArticlesListBySourceAndRange(string source, string section, int timePeriod, int? limit, int? offset, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Times.Wire.Search.Models.IArticlesListBySourceAndRange200ApplicationJson>, System.Threading.Tasks.Task> onOK, Microsoft.Rest.ClientRuntime.IEventListener eventListener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "http://api.nytimes.com/svc/news/v3//content/"
                        + System.Uri.EscapeDataString(source)
                        + "/"
                        + System.Uri.EscapeDataString(section)
                        + "/"
                        + (timePeriod.ToString())
                        + ".json"
                        + "?"
                        + (null == limit ? System.String.Empty : "limit=" + System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == offset ? System.String.Empty : "offset=" + System.Uri.EscapeDataString(offset.ToString()))
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ArticlesListBySourceAndRange_Call(request,onOK,eventListener,sender);
            }
        }
        /// <summary>Actual wire call for <see cref="ArticlesListBySourceAndRange" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Rest.ClientRuntime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ArticlesListBySourceAndRange_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Times.Wire.Search.Models.IArticlesListBySourceAndRange200ApplicationJson>, System.Threading.Tasks.Task> onOK, Microsoft.Rest.ClientRuntime.IEventListener eventListener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;
                    switch ( _response.StatusCode )
                    {
                        case System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Times.Wire.Search.Models.ArticlesListBySourceAndRange200ApplicationJson.FromJson(Carbon.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="ArticlesListBySourceAndRange" /> method. Call this like the actual call, but you will
        /// get validation events back.
        /// </summary>
        /// <param name="source">Limits the set of items by originating source
        /// all = items from both The New York Times and The International New York Times
        /// nyt = New York Times items only
        /// iht = International New York Times items only
        /// </param>
        /// <param name="section">Limits the set of items by one or more sections
        /// all | One or more section names, separated by semicolons
        /// To get all sections, specify all. To get a particular section or sections, use the section names returned by this request:
        /// http://api.nytimes.com/svc/news/v3/content/section-list.json
        /// </param>
        /// <param name="timePeriod">Limits the set of items by time published, integer in number of hours</param>
        /// <param name="limit">Limits the number of results, between 1 and 20</param>
        /// <param name="offset">Sets the starting point of the result set</param>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ArticlesListBySourceAndRange_Validate(string source, string section, int timePeriod, int? limit, int? offset, Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(source),source);
                await eventListener.AssertEnum(nameof(source),source,@"all", @"nyt", @"iht");
                await eventListener.AssertNotNull(nameof(section),section);
            }
        }
        /// <summary>Actual wire call for <see cref="ArticlesListBySource" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Rest.ClientRuntime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ArticlesListBySource_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Times.Wire.Search.Models.IArticlesListBySource200ApplicationJson>, System.Threading.Tasks.Task> onOK, Microsoft.Rest.ClientRuntime.IEventListener eventListener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;
                    switch ( _response.StatusCode )
                    {
                        case System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Times.Wire.Search.Models.ArticlesListBySource200ApplicationJson.FromJson(Carbon.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="ArticlesListBySource" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="source">Limits the set of items by originating source
        /// all = items from both The New York Times and The International New York Times
        /// nyt = New York Times items only
        /// iht = International New York Times items only
        /// </param>
        /// <param name="section">Limits the set of items by one or more sections
        /// all | One or more section names, separated by semicolons
        /// To get all sections, specify all. To get a particular section or sections, use the section names returned by this request:
        /// http://api.nytimes.com/svc/news/v3/content/section-list.json
        /// </param>
        /// <param name="limit">Limits the number of results, between 1 and 20</param>
        /// <param name="offset">Sets the starting point of the result set</param>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ArticlesListBySource_Validate(string source, string section, int? limit, int? offset, Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(source),source);
                await eventListener.AssertEnum(nameof(source),source,@"all", @"nyt", @"iht");
                await eventListener.AssertNotNull(nameof(section),section);
            }
        }
        /// <summary>Actual wire call for <see cref="ArticlesList" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Rest.ClientRuntime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ArticlesList_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Times.Wire.Search.Models.IArticlesList200ApplicationJson>, System.Threading.Tasks.Task> onOK, Microsoft.Rest.ClientRuntime.IEventListener eventListener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;
                    switch ( _response.StatusCode )
                    {
                        case System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Times.Wire.Search.Models.ArticlesList200ApplicationJson.FromJson(Carbon.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="ArticlesList" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="url">The complete URL of a specific news item, URL-encoded or backslash-escaped</param>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ArticlesList_Validate(string url, Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(url),url);
            }
        }
    }
}