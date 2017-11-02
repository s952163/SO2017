open System

type  MyRec = {
    Name : string
    Id : int
}

let myrecs = [{Name="Joe";Id=10};{Name="Jane";Id=11}]

let row1 = query {
    for row in myrecs do
    where (row.Name="Joe")
    exactlyOneOrDefault
}

isNull row1