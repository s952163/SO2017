let xs1 = [[3,2,1]; [4,3,5]] 
[for x in xs.[0] do for y in xs.[1] do yield x + y]
let xs = [[3;2;1]; [4;3;5]]

(xs.[0],xs.[1]) ||> List.map2 (+)

xs 
|> List.transpose
|> List.map List.sum

xs 
|> List.reduce (List.map2 (+))

xs |> List.reduce 