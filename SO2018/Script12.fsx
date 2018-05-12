open System
open System.Linq
let x = Ok 1
let y = Error "Oops"

let results = [x;y]

List.tryHead results

let results2: seq<Result<int,string>> = [] |> Seq.ofList

results2.FirstOrDefault()