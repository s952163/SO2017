let ms = [("a",1);("b",2)]

let map1 = ms |> Map.ofList

map1 |> Map.toArray |> Array.map snd

ms |> dict |> Seq.map (fun (KeyValue (k, v)) -> v)


seq { 1.. 4} |> Seq.replicate 10000 |> Seq.concat |> Seq.take 10 |> Seq.toArray

seq { 1 .. 4} |> Seq.toArray |> Array.take 7

Seq.initInfinite (fun _ -> seq { 1 .. 4 } ) |> Seq.concat |> Seq.take 5 |> Seq.toArray 
