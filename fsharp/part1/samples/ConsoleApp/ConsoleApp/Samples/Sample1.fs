
// ********************************************
// *
// *            F# primitives
// *
// ********************************************


module ConsoleApp.Samples.Sample1

open System

// Variables
let var1 = 1
let _, var2 = Int32.TryParse "AAAA"

// Numeric types

let int32   = 1    // System.Int32
let int16   = 1s   // System.UInt16
let int64   = 1L   // System.Int64
let uint64  = 1UL  // System.UInt64
let double  = 1.0  // System.Double
let float32  = 1.0f // System.Single
let byte    = 1uy  // System.Byte
let sbyte   = 1y   // System.SByte
let decimal = 1M   // System.Decimal
let bigint  = 1I   // System.Numerics

// Arithmetic operations

let op1 = ((float (((1 + 1 * 2) - 1) / 1) ) ** 2.0) % 2.0

// Bitwise operations

let bop1 = ((((0b1111 &&& 0b0011) ||| 0x00FF) ^^^ 0x1) <<< 1) >>> 1

// Strings

let str1 = "111-\
                            222-\
                                                333"

// Boolean

let bool1 = not (true && false) || false

// Equality operation

let equality1 = ((1 <= 2) = (2 >= 1)) <> false

// Sequences

let tuple1 = (1, "Twee", 3.0)
let _, el2, _ =  tuple1

let list1 = 0 :: [1; 2; 3]
let list2 = list1 @ [4 .. 10]
let list3 = []

let array1 = [|3 .. 7|]

// Optional types

let some1 : _ option = Some(1)
let some2 : 'a option = None