let x = [1;2;3]
let y = ["a";"b";"c"]

let z = ["d";"e";"f"]

type MyRec = {
    Time:int
    Steps:string
    Ma:string
}

let tupOfSeq = (x;y;z)

Seq.map3 (fun x y z -> {Time=x;Steps=y;Ma=z}) x y z

(x,y,z) |||> Seq.map3  (fun x y z -> {Time=x;Steps=y;Ma=z}) 


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
        },
    "236": {
        "Id": "002",
        "Name": "X. Y. Other",
        "IdDatetime": "2016-11-11T13:10:00+00:00"
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

[<Literal>]
let jsonText2 = """
{
"record": {
    "235": {
        "Id": "001",
        "Name": "A. N. Other",
        "IdDatetime": "2017-11-11T13:10:00+00:00"
    },
    "255": {
        "Id": "005",
        "Name": "D. Other",
        "IdDatetime": "2017-11-11T13:10:00+00:00"
    }
  }
}
"""

let json1 = JsonValue.Parse(jsonText2)
let json2 = json1?record

let json3 = 
    match json2 with
        | JsonValue.Record x -> x


let json4 = 
json3 
|> Array.map (function _,x -> x) 

let json4 = 
    match json3 with
    [|(_,x)|] -> x



let extractInnerJson (x: (string * JsonValue) []) =
    match x with  
    [|(_,x)|] -> Some x
    | _ -> None

//let (json4:JsonValue []) =
let json4 = 
    json3
    |> extractInnerJson

typedefof<System.Void> = typedefof<unit>
typedefof<unit> = typedefof<unit>
typedefof<unit>

typedefof<System.Void>