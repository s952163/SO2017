#r @"..\packages\Newtonsoft.Json\lib\net45\Newtonsoft.Json.dll"

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