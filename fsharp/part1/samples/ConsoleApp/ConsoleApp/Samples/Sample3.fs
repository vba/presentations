

// ********************************************
// *
// *         F# lists manipulations
// *
// ********************************************


module ConsoleApp.Samples.Sample3

open System

let list1 = [1 .. 10]

printfn "length %d" (List.length list1)
printfn "head %d" (List.head list1)
printfn "tail %A" (List.tail list1)
printfn "tryFind -1 %A" ((List.tryFind (fun x -> x = -2) list1).IsNone)
printfn "exists -1 %A" (List.exists (fun x -> x = -1) list1)
printfn "map %A" (List.map (fun x -> float x) list1)
printfn "reduce %A" (List.reduce (fun x y -> x + y) list1)
printfn "fold %A" (List.fold (fun acc x -> acc+"_"+x.ToString()) "" list1)