
module FizzBuzz

type FizzBuzzResult = Fizz | Buzz | FizzBuzz | Number of int

let printer (input: FizzBuzzResult) = 
    match input with
    | Fizz -> "Fizz"
    | Buzz -> "Buzz"
    | FizzBuzz -> "FizzBuzz"
    | Number nbr -> string nbr

let fizzBuzz input =
    match input with
    | number when number % 15 = 0 -> FizzBuzz
    | number when number % 5 = 0 -> Buzz
    | number when number % 3 = 0 -> Fizz
    | _ -> Number input

let fizzBuzzFunc (input: int) = printer (fizzBuzz input)
