let p = [ [0;2;1]; [7;2;5]; [8;2; 10]; [44; 33; 9]]

//Filtered List: [1;5;10]

p 
|> List.filter (List.contains 2)
//|> List.map (fun x -> x.[2])
|> List.map (List.item 2)
