module Edna.Tests

open Edna
open NUnit.Framework

[<Test>]
let ``aFunc returns 42`` () =
  let result = BasicFunctions.aFunc 42
  printfn "%i" result
  Assert.AreEqual(42,result)
