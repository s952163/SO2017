let array1 = [|1;2;3|]
let array2 = [|"a";"b";"c"|]

let join (x:int) (y:string) = string x + y
array2
|> Array.map (fun x -> (Array.map array1 join) x)

type Producer<'a> (x:'a) =
    do printfn "%A" x


type Subscriber<'a> (x:'a) =
    do printfn "%A" x
    
let listen<'a> (producers : Producer<'a> array) (subscribers : Subscriber<'a> array) = 
  producers
  |> Array.map (fun p -> Array.map MailboxProcessor<'a>.Start subscribers |> p)
  |> Async.Parallel