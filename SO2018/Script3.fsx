let cartesian2 (xs: int64 list) ys =
  xs |> List.collect (fun x -> ys |> List.map (fun y -> x * y))

let cartesian xs ys =
    xs |> List.collect (fun x -> ys |> List.map (fun y -> x * y))

([1L;2L;3L],[1L;2L;3L]) ||> cartesian