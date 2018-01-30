open System.IO
let okdir = @"c:\tmp\"
let baddir = @"L:\Finance"

let checkDir dir = 

    try 
        Directory.GetDirectories(dir) |> ignore
        printfn "%A" "Processed"
    with 
        | :? System.UnauthorizedAccessException as ex -> failwith ex.Message
        | :? System.IO.IOException as ex -> failwith ex.Message 
    //    | :? System.Exception as ex -> failwith ex.Message

checkDir okdir
checkDir baddir


let mySum x y = x + y

let mySum2 = (+)

mySum 4 7
mySum2 4 7