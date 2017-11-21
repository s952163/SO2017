let x = [1;2;3]
let y = ["a";"b";"c"]

let z = ["d";"e";"f"]

type MyRec = {
    Time:int
    Steps:string
    Ma:string
}

let tupOfSeq = (x;y;z)

Seq.map3 (fun x y z -> {Time=x;Steps=y;Ma=z}) x y z

(x,y,z) |||> Seq.map3  (fun x y z -> {Time=x;Steps=y;Ma=z}) 