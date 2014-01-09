
// ********************************************
// *
// *         Discriminated unions
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
                | [ first; second ]
                    -> sprintf "Two cards: %A and %A" first second
                | _ -> "Nothing"

            let cards = List.nth deckOfCards (Random().Next(List.length deckOfCards))

