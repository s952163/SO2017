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
