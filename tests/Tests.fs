module Tests

open System
open Xunit

[<Fact>]
let ``My test`` () =
    Assert.Equal(Program.adrianBarbershop (), 67)
