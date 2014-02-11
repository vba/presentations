// ********************************************
// *
// *         Some additional features
// *
// ********************************************


module ConsoleApp.Samples.Sample8

    module ``Units of measure`` =
        
        [<Measure>] 
        type F = 
            static member ToCel(x: float<F>) = (5.0<C> / 9.0<F>) * (x - 32.0<F>)
        and [<Measure>] C = 
            static member ToFar(x: float<C>) = (9.0<F> / 5.0<C> * x) + 32.0<F>

        let nowC = 20.0<C>
        let nowF = C.ToFar(nowC)

        let nowC2 = 20.0<C>

        type Temp = 
            | Cel of float<C> 
            | Far of float<F>

        //let rubbish1 = nowC + nowF

        [<Measure>] 
        type Sec

        [<Measure>] // Cooling ratio 
        type CR = C / Sec

        let thisPlaceCR = 0.2<CR>

    module ``Extension methods`` =
        open System

        type String with
            member s.IsMatch (pattern) = 
                Text.RegularExpressions.Regex.IsMatch(s, pattern)

    module ``Async programming`` =
        
        open System
        open System.Net
        open Microsoft.FSharp.Control.WebExtensions

        let contentType url =

            async {let req =  WebRequest.Create(Uri url)
                   use! resp = req.AsyncGetResponse()
                   return (url, resp.ContentType)}
 
        let sites = ["http://www.bing.com";
                        "http://www.google.com";
                        "http://www.yahoo.com";
                        "http://www.search.com"]

        let contentTypes =
            Async.Parallel [for site in sites -> contentType site ]
                |> Async.RunSynchronously

        contentTypes |> printfn "%A"

// Talking about headers files
// Methods overriding
// Modules vs namespaces
// Generics
// Events and delegates
// Monads and computation expressions
// Scripting
// Async programming
// IDEs support
