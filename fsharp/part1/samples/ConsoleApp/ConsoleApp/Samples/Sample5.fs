// ********************************************
// *
// *         Pattern matching
// *
// ********************************************


module ConsoleApp.Samples.Sample5

    let (.&&) a b = 
        match a, b with
        | true, true -> true
        | _, _ -> false

    let und = true .&& true

    let greetings tuple = 
        match tuple with
        | ("Gunter", _) | ("Günter", _) 
            -> printfn "Welkom en goudendag Gunter!"
        | (_, "Martin") 
            -> printfn "Béjour Mr. Martin!"
        | _ when (snd tuple).EndsWith("ski") 
            || (snd tuple).EndsWith("ska") 
            -> printfn "Vitaj %s!" (fst tuple)
        | _ -> printfn "Greetings to you %s!" (fst tuple)

    let rec listLength l =
        match l with
        | []    -> 0
        | [_]   -> 1
        | [_; _]   -> 2
        | [_; _; _]   -> 3
        | head :: tail -> 1 + listLength tail 

    let rec listLength2 = function
        | []    -> 0
        | [_]   -> 1
        | [_; _]   -> 2
        | [_; _; _]   -> 3
        | head :: tail -> 1 + listLength tail 