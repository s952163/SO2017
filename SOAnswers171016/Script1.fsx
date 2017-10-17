let list1 = ["Alpha";"Bravo";"Charlie"]
let list2 = ["3";"5";"7"]
let list3 = ["11";"13";"17"]
let list4 = ["19";"23";"29"]

let lists = [list1;list2;list3;list4]
lists.Length
lists |> List.map List.length

lists |> List.length
lists.[1].Length

[|for i in [0 .. (lists.Length - 1)] do
    for j in [0 .. (lists.[i].Length - 1)] do 
    yield lists.[j].[i]
|] 

|> Array.splitInto (lists.Length - 1)
|> Array.map (fun x -> String.concat "," x)


lists
lists.[0]
lists
|> List.map List.head


let rec transpose xs =
    match xs with
    []::xs -> []
    | xs -> List.map List.head xs :: transpose (List.map List.tail xs)

transpose lists 
|> Array.ofList
|> Array.map (fun x -> String.concat "," x)

lists
|> List.map (List.tail >> List.head)

lists |> List.fold (fun x ->  )

[1;2;3;4] |> List.fold (fun a b -> a + b) 0 

lists |> List.fold (fun i j ->  j :: [List.head i] ) [[]]

lists 
|> List.mapFold (fun i j -> j :: [List.head i]) [[]]