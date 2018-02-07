module internal MyModule.Print
open MyModule.Types


[<EntryPoint>]
let main argv =
    let x = Add 10
    // printfn "%A" x
    // printfn "%A" MyModule.Types.x 
    // printfn "%A" argv
    let printStuff (x:Action) =
        printfn "%A" x
    printStuff x
    printStuff (Types.Add 10)
    0 // return an integer exit code
