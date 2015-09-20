module Edna.Tests

open Edna
open NUnit.Framework

[<Test>]
let ``simpleFunc returns 42`` () =
  let result = BasicFunctions.simpleFunc 42
  printfn "%i" result
  Assert.AreEqual(42,result)
