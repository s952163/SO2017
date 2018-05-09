let first  = [|"A"; "B"; "C"; "A"; "B"; "A"; "C"; "B"; "C"; "C"; "C"|]
let second = [|"A"; "B"; "C"|]
let third  = [|"1"; "2"; "3"|]

let lookupTbl = Map(Array.zip second third) //create a Map/Dictionary from the zipped values

first
|> Array.map (fun x -> lookupTbl.[x]) //Use the first array's values as keys
//val it : string [] = [|"1"; "2"; "3"; "1"; "2"; "1"; "3"; "2"; "3"; "3"; "3"|]

first
|> Array.map (fun x -> lookupTbl.TryFind(x)) //Use the first array's values as keys
//val it : string [] = [|"1"; "2"; "3"; "1"; "2"; "1"; "3"; "2"; "3"; "3"; "3"|]


let rplc (x:string[]) (y:string[]) (z:string[]) = 
  first
  |> Array.collect (fun w -> 
                        Array.map2 (fun x y -> 
                                                match (w = x) with
                                                | true -> Some(y)
                                                | _ -> None ) second third)
  |> Array.choose id
 
let fourth = 
  rplc first second third

printfn ""
printfn "fourth: %A" fourth

// val fourth : string [] =
//   [|"1"; "2"; "3"; "1"; "2"; "1"; "3"; "2"; "3"; "3"; "3"|]
// val it : unit = ()