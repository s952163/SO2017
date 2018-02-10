module internal MyModule.Types

type Action =
    | Add of int
    | Update of int * string
    | Delete of string

let x = Add 5
printfn "%A" x


let scanMethod x =
    x + 1

let someFn = 
    (*) 

let x = someFn >> (fun f -> f >> scanMethod)
x 10 20
(fun f -> f >> scanMethod)
let y = scanMethod >> someFn
scanMethod (someFn 10 20)
