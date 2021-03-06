#r @"..\packages\Newtonsoft.Json\lib\net45\Newtonsoft.Json.dll"
#nowarn "25"
#warnaserror "25"
open Newtonsoft.Json

type MyDU = 
    | Path of path:string
    | File of name:string

let path = Path @".\packages\Newtonsoft.Json\lib\net45\"
let file = File "Newtonsoft.Json.dll"

let json = JsonConvert.SerializeObject(path)
let json2 = JsonConvert.SerializeObject(file)

let jsonout = JsonConvert.DeserializeObject<MyDU>(json)
let jsonout2  = JsonConvert.DeserializeObject<MyDU>(json2)
jsonout
jsonout2


type TestMe ()=
    override __.ToString() = null

TestMe()

printfn "%A" (TestMe())

printfn "%A" ()

type Point =
    { X: float
      Y: float }

let fib = [for i in 1..10 -> {X=1.;Y=2.}]

fib |> printfn "%A"

fib |> Seq.length

fib |> List.iter (fun x -> printfn "%A" x)
fib |> List.iter (fun x -> printfn "%A" (x.X,x.Y))

fib |> List.iter (printfn "%A")

//// SQL:
type Column = string
type Table = string

type QueryAggregate =
  | MaxBy of Column

type Query = 
  { Table : Table
    Aggregate : QueryAggregate }

let q1 = { Table = "table1"; Aggregate = MaxBy "Datadate" }
let q2 = { Table = "table2"; Aggregate = MaxBy "Datadate" }

let translateAgg = function
  | MaxBy col -> sprintf "MAX(%s)" col

let translateQuery q =
  sprintf "SELECT %s FROM %s" (translateAgg q.Aggregate) q.Table

translateQuery q1
translateQuery q2

(translateAgg q1.Aggregate)
q1.Table

let bytes = [| 104uy; 101uy; 108uy; 108uy; 111uy |]

bytes 
|> Array.pairwise
|> Array.findIndex (fun x -> fst x = snd x)

type DU =
    | Whatever
    | Tag of string

type Wihdissd =
    | Tags

__SOURCE_DIRECTORY__

#r @"..\packages\FSharp.Data\lib\net40\FSharp.Data.dll"
open FSharp.Data
open System
open System.IO
[<Literal>]
let JsonSource = __SOURCE_DIRECTORY__ + @"\test.json"

type JSonType = JsonProvider<JsonSource>

let json1 = JSonType.GetSamples()

let anotherPath = @"C:\tmp"
let anotherJson = anotherPath + @"\test.json"
let json2 = JSonType.Load(anotherJson)

__SOURCE_FILE__


let [<Literal>] x1 = __SOURCE_DIRECTORY__ + @"\test.json"
let [<Literal>] x2 = "x2"

let x3 = 
  let newFunc x =
    match x with
    | 1 -> x1
    | 2 -> x2
  newFunc 

let x4 = x3 1
  
type NewJson3 =  JsonProvider<x4>

//SO170811

type NonZeroInteger = private NonZeroInteger of int 
let createNZI i = 
  if i = 0 then
    Error "NonZeroInteger can't be Zero"
  else 
    Ok (NonZeroInteger i)

createNZI 10
createNZI 0


