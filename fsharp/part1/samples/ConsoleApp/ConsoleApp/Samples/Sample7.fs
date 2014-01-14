// ********************************************
// *
// *         OOP in F#
// *
// ********************************************


namespace ConsoleApp.Samples.Sample7
open System
    type IExtraterrestrial = 
        interface
        end

    type IAnimal =
        abstract member Walk: unit -> unit
        abstract member Run: unit -> unit

    [<AbstractClass>]
    type Insecta(habitat: String, social: bool) =

        member me.Social with get() = social
        member me.Habitat with get() = habitat

        abstract member Fly: unit -> unit
        default me.Fly() = printfn "zzzzzzzzzzz........."

    [<AbstractClass>]
    type Aves(habitat: String, diet: String) =

        member me.Habitat with get() = habitat
        member me.Diet with get() = diet

        abstract member Fly: unit -> unit
        default me.Fly() = printfn "fffffffffff........."


    type HoneyBee(habitat: String) = 
        inherit Insecta(habitat, true)
        override me.Fly() = printfn "bzzzzzzzz........"

        interface IAnimal with
            member me.Walk() = printfn "[HoneyBee walk sound]"
            member me.Run() = printfn "[HoneyBee run sound]"


    type BladEagle(habitat: String, diet: String) = 
        inherit Aves (habitat, diet)
        override me.Fly() = printfn "(ffffffffff.........)²"

        new(diet) = 
            let usa = "usa"
            BladEagle(usa, diet)

        new() =
            BladEagle("bugs")

        interface IAnimal with
            member me.Walk() = printfn "[Eagle walk sound]"
            member me.Run() = printfn "[Eagle run sound]"

    module TestAll =

        let eagle1: IAnimal = BladEagle() :> IAnimal
        let eagle2 = BladEagle("France", "cheese")
        let honeyBee1 = HoneyBee("France")

        eagle1.Run()
        (eagle2 :> IAnimal).Walk()
        
        printfn "%A" (eagle1 :?> BladEagle).Habitat

        //let thing1 = (eagle1 :?> IExtraterrestrial)
        //let thing2 = (eagle2 :> IExtraterrestrial)

        let tevin = {
            new IAnimal with
                member tevin.Run() = printfn "run Tevin, run ...."
                member tevin.Walk() = printfn "ttttttt...."
        }

        tevin.Run()

        // Duck typing
        let inline fly (x : ^T) = (^T : (member Fly : unit->unit) (x))
        fly(honeyBee1)
        fly(eagle2)
