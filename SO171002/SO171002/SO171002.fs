module SO171002
open System

[<EntryPoint>]
let main _ =
    printfn "value=%i" 1
    let format = "value=%i" 
    printfn (Printf.TextWriterFormat<_> format) 1
    0 // return an integer exit code
