let ms = [("a",1);("b",2)]

let map1 = ms |> Map.ofList

map1 |> Map.toArray |> Array.map snd

ms |> dict |> Seq.map (fun (KeyValue (k, v)) -> v)