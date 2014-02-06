// ********************************************
// *
// *         F# functions composition
// *
// ********************************************


module ConsoleApp.Samples.Sample4
    open System
    open System.IO

    module AwfulApproach =
        let sizeOfFolder folder =
            
            // E3( E2 ( E1() ) )
            // 1. Not type inference
            // 2. file* are passed as param to following function
            // 3. Really awful code, you need a time to understand it

            let filesInFolder : string [] = Directory.GetFiles(folder, "*.*",SearchOption.AllDirectories)

            let fileInfos : FileInfo [] = Array.map(fun file -> new FileInfo(file)) filesInFolder
            let fileSizes : int64 [] = Array.map(fun (info : FileInfo) -> info.Length) fileInfos
            let result = Array.sum fileSizes
            result

    module UgglyApproach =
        let sizeOfFolder folder =
            Array.sum
                (Array.map
                    (fun (info : FileInfo) -> info.Length)
                    (Array.map
                        (fun file -> new FileInfo(file))
                        (Directory.GetFiles(
                            folder, "*.*",
                            SearchOption.AllDirectories))))

    module PipeForwardApproach =
        // It just takes a param before the function f and put it in the end
        let (|>) x f = f x

        let sizeOfFolder folder =
            let getFiles folder = Directory.GetFiles (folder, "*.*", SearchOption.AllDirectories)

            folder
                |> getFiles
                |> Array.map (fun file -> new FileInfo(file))
                |> Array.map (fun info -> info.Length)
                |> Array.sum

    module ForwardCompositionApproach =
        
        let (>>) f g x = g(f x)

        let sizeOfFolder  = 
            let getFiles folder = Directory.GetFiles (folder, "*.*", SearchOption.AllDirectories)

            let temp = (fun s -> getFiles s) >> Array.map (fun file -> new FileInfo(file))

            getFiles 
                >> Array.map (fun file -> new FileInfo(file))
                >> Array.map (fun info -> info.Length)
                >> Array.sum

            
    module BackwardOperators = 
        
        let (<|) f x = f x

        List.iter (printfn "%d") <| [1 .. 3]
        printfn "The result of sprintf is %s" <| sprintf "(%d, %d)" 1 2

        let (<<) f g x = f(g x)

        let notEmpty = [[1]; []; [4;5;6]; [3;4]; []; []; []; [9]] |> List.filter(not << List.isEmpty)