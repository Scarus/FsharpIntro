module FizzBuzzReloaded

// same as before ... but better

type FizzBuzzResult = Fizz | Buzz | FizzBuzz | Number of int

let printer (input: FizzBuzzResult) = 
    match input with
    | Fizz -> "Fizz"
    | Buzz -> "Buzz"
    | FizzBuzz -> "FizzBuzz"
    | Number nbr -> string nbr

// custom pattern
let (|IsMultipleOf|_|) multiplier n  =
    match n % multiplier with
    | 0 -> Some ()
    | _ -> None

let doFizzBuzz input =
    match input with
    | IsMultipleOf 5 & IsMultipleOf 3  -> FizzBuzz
    | IsMultipleOf 5  -> Buzz
    | IsMultipleOf 3  -> Fizz
    | _ -> Number input

let fizzBuzz nbr =
    nbr |> doFizzBuzz |> printer
