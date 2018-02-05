open System


type DBRow1 = {
    id: string
    createdAt: DateTime
}

type DBRow2 = {
    id: string
    createdAt: DateTime
    address: string
}

let row1 = {id = "Row1"; createdAt = DateTime.Now}
let row2 = {id = "Row2"; createdAt = DateTime.Now; address = "NYC"}

type IDBRow<'A> =
    abstract member Data:(string * DateTime) 

let Data1 (x:DBRow1)  = {
    new IDBRow<_> with
        member __.Data = (x.id, x.createdAt)
}

let Data2 (x: DBRow2) = {
    new IDBRow<_> with
    member __.Data = (x.id, x.createdAt)
}

let getData (ifun: 'a -> IDBRow<'b>) xrec = 
    (ifun xrec).Data

getData Data1 row1
getData Data2 row2

(Data1 row1).Data

let getData1 = getData Data1
let getData2 = getData Data2

type DBRows =
    | DBRow1 of DBRow1
    | DBRow2 of DBRow2 

let (|Db1|_|) (x: DBRows) =
    match x with 
    | DBRow1 x -> Some(Data1 x)
    | _ -> None

let (|Db2|_|) x =
    match x with 
    |  DBRow2 x -> Some(Data2 x)
    | _ -> None

let dataFactory (x: DBRows) =
    match x with
    | Db1 x -> x.Data
    | Db2 x -> x.Data
    | _ -> failwith "Unknown row."
  
dataFactory (DBRow1 row1)
dataFactory (DBRow2 row2)

