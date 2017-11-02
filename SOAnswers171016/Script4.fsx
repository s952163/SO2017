//open System
open System.Linq

let z = struct (2,3)
let myQueryable = [| struct(1, 1); struct (2,2) |].AsQueryable()
let check =
    query {
            for x in myQueryable do
            select x
          } |> Seq.where(fun x -> x = struct (2,2))

check //val it : seq<int * int> = seq [(2, 2)]
let check' =
        query {
            for x in myQueryable do
            where (x = struct (2, 2)) 
            select x
            }

check' //val it : seq<int * int> = seq [(2, 2)] 