#load @"..\packages\RProvider\RProvider.fsx"

open System
open RDotNet
open RProvider
open RProvider.graphics

let floatList = [1. ..10.]
let decList = [1M .. 10M ]
let labels

R.plot(floatList)
R.plot(decList)

decList 
|> List.map float 
|> R.plot

R.plot(floatList,floatList)


let xs = [1;2;3;4;2]
xs |> List.countBy (fun x -> x = 2)
xs  |> List.filter (fun x -> x = 2 ) |> List.length
let xsa = xs |> List.toArray
let xsi = xs |> List.toSeq

(0,xs) ||> List.fold (fun acc elem -> match elem with 
                                        | 2 -> acc + 1
                                        | _ -> acc)
                        