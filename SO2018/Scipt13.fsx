open System.Linq

type Result<'a> =
| Ok of 'a
| Error

let results : seq<Result<int>> = [] |> Seq.ofList

let firstResult = results.FirstOrDefault()

Seq.tryHead results |> Option.defaultValue Error


let optionResults: seq<Option<int>> = [] |> Seq.ofList

optionResults.FirstOrDefault()

Option.defaultValue