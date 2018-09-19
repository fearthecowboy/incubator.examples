

I've knocked off a few examples here:

This shows the low-level  API implementation -- at this point, this is intended to have a 'Consumer' layer (whether that means a .NET SDK, or PowerShell, or whatever) built on top of it. I have a PowerShell generator that just hit beta that uses this.

Notable bits:
- Includes all the code needed, so zero library dependencies. (and it will soon be made all private and namespace normalized to the desired namespace)
- Uses a simpler HTTP Pipeline extension model (Essentially, an ISendAsync implementation is all that's required) ; HttpClient is NOT hard-baked into the solution, and doesn't have to be used (in this example, is the default tho')
- At the low-level, the APIs make no judgements about whether some responses are errors (ie, 4xx or 5xx) -- all declared responses have a clean, no-exceptions handling path.
- Speaking of exceptions, the only cases for throwing are (a) you lied in your swagger ( ie, a response came back that wasn't declared, and you didn't declare a 'default' response) or (b) something in the ISendAsync implementation threw. 
- Doesn't use reflection-based serialization.  Given that we know everything about the responses at generation time, we generate statements for serialization (using a much simple JSON DOM) that doesn't have to do any reflection, and doesn't need attributes. (_Bye-bye newtonsoft.json_)
- `allOf` is handled via composition and interfaces, not inheritance. MUCH MUCH CLEANER MODELS. 
- Polymorphic models are well handled
- XML and JSON Serialization are handled
- No Enums -- Structs are generated that support extensibility that Enums can't do. (ie, tolerant of new values that aren't declared)
- low-level API is built into a single class.
- can dispatch responses for multiple content-types/return codes easily.
- fully cancellable throughout 
- Model/parameter validation is tangential to actual calls (and you can get all the validation errors back without making a call)
- events thru the process are very lightweight -- if you don't handle them, there's very low cost
- API doesn't have any state, no setup.


example of making a call: 
``` csharp
// assuming the following API is declared 
public async System.Threading.Tasks.Task XkcdGetComic(float comicId, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Xkcd.Models.IComic>, System.Threading.Tasks.Task> onOK, Microsoft.Rest.ClientRuntime.IEventListener eventListener, Microsoft.Rest.ClientRuntime.ISendAsync sender);

// can be called with something like:
var pipeline = new HttpPipeline(); // defaults to HttpClient, no additional steps
await xkcd.XkcdGetComic( 
/* comicid */323 , 
/* onOK handler*/ async (responseMessage, result) => { 
   var comic=  await result;
   Console.WriteLine( $"URL for comic => {comic.Img}" );
}, 
/* event listener for the call (implemented IEventListener) */ this , 
/* ISendAsnyc implementation */ pipeline);


/* IEventListener - handling messages back from the call */
public async System.Threading.Tasks.Task Signal(string id, CancellationToken token, System.Func<EventData> messageData)
{
     switch (id) {
       case Events.BeforeCall:
           // tweak the message before sending it!
           if(eventData.RequestMessgae is HttpRequestMessage httpRequest) 
           {
              httpRequest.Headers.Add("x-request-flavor", "vanilla");
           }
       break;
     }
     // or you can spit out the event message
     // Console.WriteLine ($"{id}: {messageData().Message ?? System.String.Empty}");
}

```
There's a lot more thought that went into this, but you can at least take a peek at what it's doing. 
