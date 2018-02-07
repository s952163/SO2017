module internal MyModule.Types

type Action =
    | Add of int
    | Update of int * string
    | Delete of string

let x = Add 5
printfn "%A" x