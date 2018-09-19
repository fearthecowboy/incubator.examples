namespace Xkcd
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Low-level API implementation for the XKCD service.
    /// </summary>
    public class XKCD
    {

        /// <summary>
        /// Fetch comics and metadata by comic id.
        /// </summary>
        /// <param name="comicId"></param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Rest.ClientRuntime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task XkcdGetComic(float comicId, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Xkcd.Models.IComic>, System.Threading.Tasks.Task> onOK, Microsoft.Rest.ClientRuntime.IEventListener eventListener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "http://xkcd.com//"
                        + (comicId.ToString())
                        + "/info.0.json"
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.XkcdGetComic_Call(request,onOK,eventListener,sender);
            }
        }
        /// <summary>
        /// Fetch current comic and metadata.
        /// </summary>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Rest.ClientRuntime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task XkcdGetComicForToday(System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Xkcd.Models.IComic>, System.Threading.Tasks.Task> onOK, Microsoft.Rest.ClientRuntime.IEventListener eventListener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "http://xkcd.com//info.0.json"
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.XkcdGetComicForToday_Call(request,onOK,eventListener,sender);
            }
        }
        /// <summary>Actual wire call for <see cref="XkcdGetComicForToday" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Rest.ClientRuntime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task XkcdGetComicForToday_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Xkcd.Models.IComic>, System.Threading.Tasks.Task> onOK, Microsoft.Rest.ClientRuntime.IEventListener eventListener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
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
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Xkcd.Models.Comic.FromJson(Carbon.Json.JsonNode.Parse(body.Result)) ));
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
        /// Validation method for <see cref="XkcdGetComicForToday" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task XkcdGetComicForToday_Validate(Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
            }
        }
        /// <summary>Actual wire call for <see cref="XkcdGetComic" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Rest.ClientRuntime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task XkcdGetComic_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Xkcd.Models.IComic>, System.Threading.Tasks.Task> onOK, Microsoft.Rest.ClientRuntime.IEventListener eventListener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
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
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Xkcd.Models.Comic.FromJson(Carbon.Json.JsonNode.Parse(body.Result)) ));
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
        /// Validation method for <see cref="XkcdGetComic" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="comicId"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task XkcdGetComic_Validate(float comicId, Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
            }
        }
    }
}