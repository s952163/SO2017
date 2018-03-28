let listOfLists = [ [1;2;3;4;5]; [6;7;8;9;10]; [11;12;13;14;15] ]

listOfLists 
|> List.map List.head

listOfLists
|> List.map (List.item 1)

listOfLists
|> List.map (fun x -> x.[1])

let x = "test"
let (y: string) = null

isNull x
isNull y

Option.ofObj y
Option.ofObj x

let z = Some null
Option.ofObj null
match z with
| Some x -> printfn "%A" x
| None -> printfn "%A" "oops"