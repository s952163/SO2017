module internal MyModule.Types 

type Action =
    | Add of int
    | Update of int * string
    | Delete of string
    override x.ToString() = sprintf "%A" (x,x)
let x = Add 5
printfn "%A" x
printfn "%A" (x.ToString()) |> ignore
