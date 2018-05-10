let xs1 = [[3,2,1]; [4,3,5]] 
let xs = [[3;2;1]; [4;3;5]]

(xs.[0],xs.[1]) ||> List.map2 (+)

xs 
|> List.transpose
|> List.map List.sum

xs 
|> List.reduce (List.map2 (+))
//[7; 5; 6]

[for i in xs.[0] do 
 for j in xs.[1] do
 yield i + j]

[ for j in xs.[0] do
  for k in xs.[1] do
  yield j + k]

[for i in xs do yield! i]
[for i in xs do yield i]
[for i in xs do yield! "x"]



List.zip xs.[0] xs.[1]

[for i in [0..2] do yield xs.[0].[i] + xs.[1].[i]]

[for i in [0..2] do 
    for j in [0..1] do
        let x = xs.[j].[i] 
        let y = xs.[j].[i]
        yield x + y]

[for i in [0..2] do
 for j in [0..1] do
 let x = xs.[j].[i]
 yield x ]        


[for i in [0..2] do  
    let x = i
    yield x + i ]

[for i in xs do
    for j in [0..2] do
        let x1 = i.[j]
        let x2 = i.[j]
        yield (x1,x2)]


type AddString = string -> string -> string

let myFunc (x:string) (y:string) :int = failwith "oops"
