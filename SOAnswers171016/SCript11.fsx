let rec fib n = 
    ()
    match n with
    | 0 -> 1
    | 1 -> 1
    | _ -> fib (n - 1) + fib (n - 2)


let rec fib2 = 
    fun n ->
        match n with
        | 0 -> 1
        | 1 -> 1
        | _ -> fib2 (n - 1) + fib2 (n - 2)

let printX() = printfn "oops"

let rec fib3 = 
    printfn "fib" |> ignore
    fun n ->
        match n with
        | 0 -> 1
        | 1 -> 1
        | _ -> fib3 (n - 1) + fib3 (n - 2)
    

fib 6

fib2 6

fib3 6

let funcWithUnit x =
    printfn "Blah"
    x + 3

funcWithUnit 3