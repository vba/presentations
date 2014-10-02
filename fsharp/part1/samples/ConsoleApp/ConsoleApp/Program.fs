
// NOTE: If warnings appear, you may need to retarget this project to .NET 4.0. Show the Solution
// Pad, right-click on the project node, choose 'Options --> Build --> General' and change the target
// framework to .NET 4.0 or .NET 4.5.

module ConsoleApp.Main

open System

let me() = "be"

[<EntryPoint>]
let main args = 
    printf "Calculation result, must be here"
    //Console.ReadLine() |> ignore
    0