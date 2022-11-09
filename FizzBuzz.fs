
module FizzBuzz

type FizzBuzzResult = Fizz | Buzz | FizzBuzz | Number of int

let fizzBuzzFunc (input: int) = failwith "not implemented ... yet"

let printer (input: FizzBuzzResult) = 
    match input with
    | Fizz -> "Fizz"
    | Buzz -> "Buzz"
    | FizzBuzz -> "FizzBuzz"
    | Number nbr -> string nbr

let FizzBuzz input =
    match input with
    | number when number % 15 = 0 -> FizzBuzz
    | number when number % 5 = 0 -> Buzz
    | number when number % 3 = 0 -> Fizz
    | _ -> Number input