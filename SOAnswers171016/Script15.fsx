open Microsoft.FSharp.Quotations
open Microsoft.FSharp.Quotations.Patterns

type MyRec1 = {x:int; y:string}
type MyRec2 = {x:float; z:string}

let myrec1 = {x = 10; y = "Joe"}
let myrec2 = {x = 3.2; z = "Jim"}

let passQuote q (x:'a) =   <@ (%q) x @>   

passQuote <@ fun recin -> recin.y @> myrec1
