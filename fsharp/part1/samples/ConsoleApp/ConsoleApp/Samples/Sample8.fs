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
