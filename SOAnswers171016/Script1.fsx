let list1 = ["Alpha";"Bravo";"Charlie"]
let list2 = ["3";"5";"7"]
let list3 = ["11";"13";"17"]

let lists = [list1;list2;list3]

[|for i in [0 .. (lists.Length - 1)] do
    for j in [0 .. (lists.[i].Length - 1)] do 
    yield lists.[j].[i]
|] 
|> Array.splitInto (lists.Length)
|> Array.map (fun x -> String.concat "," x)
