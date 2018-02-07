module MyModule.Program
open MyModule.Types


[<EntryPoint>]
let main argv =
    let x = Add 10
    // printfn "%A" x
    // printfn "%A" MyModule.Types.x 
    // printfn "%A" argv
    MyModule.Types.x.ToString()
    0 // return an integer exit code
