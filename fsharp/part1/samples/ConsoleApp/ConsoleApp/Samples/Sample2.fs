// ********************************************
// *
// *         F# functions
// *
// ********************************************


module ConsoleApp.Samples.Sample2


    module SimpleFunctions =

        let add x y = x + y

    module PartialFunctions =
        
        open System
        open System.Text
        open System.IO
        type S = String

        let path = "c:\\windows\\grosporc\\file.txt"

        let appendFile(file: S) (text: S) = 
            let sb = new StringBuilder("Simulate writing to file " + file+ "\n")
            use sw = new StringWriter(sb)
            sw.WriteLine(text)
            printfn "%A" (sb.ToString())

        let partialAppendFile1 text = appendFile (path) text
        let partialAppendFile2 = appendFile (path)

    module RecFunctions =
        let rec fact x = if x <= 1 then 1 else x * fact (x - 1)
