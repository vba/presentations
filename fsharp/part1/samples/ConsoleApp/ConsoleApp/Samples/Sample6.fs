
// ********************************************
// *
// *     Discriminated unions and records
// *
// ********************************************


namespace ConsoleApp.Samples
    
    open System

    module Sample6 =
        module Poker = 
        
            type Suit = 
                | Heart
                | Diamond
                | Spade
                | Club

            type PlayingCard = 
                | Ace       of Suit
                | King      of Suit
                | Queen     of Suit
                | Jack      of Suit
                | ValueCard of int * Suit

            let deckOfCards = [
                for suit in [ Spade; Club; Heart; Diamond ] do
                    yield Ace(suit)
                    yield King(suit)
                    yield Queen(suit)
                    yield Jack(suit)
                    for value in 2 .. 10 do yield ValueCard(value, suit)
            ]

            let describeHoleCards = function
                | []
                | [_]
                    -> failwith "Too few cards."
                | cards when List.length cards > 2
                    -> failwith "Too many cards."
                | [ Ace(_); Ace(_) ] -> "Pocket Rockets"
                | [ King(_); King(_) ] -> "Cowboys"
                | [ ValueCard(2, _); ValueCard(2, _)]
                    -> "Ducks"
                | [ Queen(_); Queen(_) ]
                | [ Jack(_); Jack(_) ]
                    -> "Pair of face cards"
                | [ ValueCard(x, _); ValueCard(y, _) ] when x = y
                    -> "A Pair"
//                | [ first; second ]
//                    -> sprintf "Two cards: %A and %A" first second
                | _ -> "You have nothing, loser"


            let random = Random()

            let ``two cards`` = 
                deckOfCards 
                    |> List.sortBy (fun _ -> random.Next()) 
                    |> Seq.take 2
                    |> Seq.toList

            ``two cards`` |> printfn "Two random cards are %A"
            ``two cards`` |> describeHoleCards |> printfn "Random combination: %s"

            [Queen(Heart); Queen(Club)] 
                |> describeHoleCards 
                |> printfn "Forced combination: %s"

        module Records = 
            type Person = { First : string; Last : string; Age : int}

            let steve1 = { First = "Steve"; Last = "Holt"; Age = 17 }
            let steve2 = { First = "Steve"; Last = "Holt"; Age = 17 }
            let same = steve1 = steve2

            let steve3 = {steve1 with Age = 18}

