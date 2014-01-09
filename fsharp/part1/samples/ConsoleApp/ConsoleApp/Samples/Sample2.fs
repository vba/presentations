// ********************************************
// *
// *         F# functions
// *
// ********************************************


module ConsoleApp.Samples.Sample2


    module SimpleFunctions =

        let add x y = x + y
        let makeList threshold = [for i in 1 .. threshold do yield i * i]
        
        // strange name
        let ``Some spec to accomplish``() = assert (true = true)

        //infix notation
        let (===) str pattern = System.Text.RegularExpressions.Regex.IsMatch(str, pattern)


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
        // simple recursion
        let rec fact x = if x <= 1 then 1 else x * fact (x - 1)

        // mutual recursion
        // let isOdd n = if n = 0 then false elif n = 1 then true else (isEven (n - 1))
        // let isEven n = if n = 0 then true elif n = 1 then false else (isOdd (n - 1))

        // symbolic operators (!%&*+-./<=>?@^|~)
        let (!) = fact



