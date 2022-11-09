module Tests

open System
open Xunit

open FizzBuzz

[<Theory>]
[<InlineData(1, "1")>]
[<InlineData(7, "7")>]
[<InlineData(3, "Fizz")>]
[<InlineData(9, "Fizz")>]
[<InlineData(5, "Buzz")>]
[<InlineData(10, "Buzz")>]
[<InlineData(15, "FizzBuzz")>]
[<InlineData(45, "FizzBuzz")>]
let ``FizzBuzz test`` input output =
    Assert.Equal(output, fizzBuzzFunc input)