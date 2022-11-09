
module FizzBuzz

type FizzBuzzResult = Fizz | Buzz | FizzBuzz | Number of int

let fizzBuzzFunc (input: int) = failwith "not implemented ... yet"

let printer (input: FizzBuzzResult) = 
    match input with
    | Fizz -> "Fizz"
    | Buzz -> "Buzz"
    | FizzBuzz -> "FizzBuzz"
    | Number nbr -> string nbr
