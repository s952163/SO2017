module AsyncTimer
open System

[<EntryPoint>]
let main argv =
    let timer = new Timers.Timer(3000.)
    let event = Async.AwaitEvent(timer.Elapsed) |> Async.Ignore

    printfn "%A" DateTime.Now
    timer.Start()
    printfn "%A" "Ok...."
    Async.RunSynchronously event
    printfn "%A" "Done." 
    printfn "%A" argv
    0 // return an integer exit code
