
module FizzBuzz

// simple ... basic ...

// presenter d'abord l'union discriminée
type FizzBuzzResult = Fizz | Buzz | FizzBuzz | Number of int

let printer (input: FizzBuzzResult) = 
    match input with
    | Fizz -> "Fizz"
    | Buzz -> "Buzz"
    | FizzBuzz -> "FizzBuzz"
    | Number nbr -> string nbr

let doFizzBuzz input =
    match input with
    | number when number % 15 = 0 -> FizzBuzz
    | number when number % 5 = 0 -> Buzz
    | number when number % 3 = 0 -> Fizz
    | _ -> Number input

let fizzBuzz (input: int) = printer (doFizzBuzz input)
