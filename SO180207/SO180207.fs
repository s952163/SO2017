#if INTERACTIVE
#load @"../MyModule.fs"
#endif

open MyModule.Types

[<EntryPoint>]
let main argv =
    let x = Add 10
    let printStuff (x:Action) =
        printfn "%A" x
    printStuff x
    printStuff (Add 10)
    0 // return an integer exit code
