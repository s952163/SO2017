#r @"../packages/FSharp.Data/lib/net40/FSharp.Data.dll"

open FSharp.Data
open FSharp.Data.JsonExtensions

[<Literal>]
let jsonText = """
{
"record": {
    "235": {
        "Id": "001",
        "Name": "A. N. Other",
        "IdDatetime": "2017-11-11T13:10:00+00:00"
        }
    }
}
"""

let json1 = JsonValue.Parse(jsonText)
let json2 = json1?record

let json3 = 
    match json2 with
        | JsonValue.Record x -> x

let json4 = 
    match json3 with
    [|(_,x)|] -> x

let jsonSample = jsonType1.GetSample()

for row in jsonSample do
    printfn "%A" row