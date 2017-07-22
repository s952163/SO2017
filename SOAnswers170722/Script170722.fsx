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


