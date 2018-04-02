open System

type Car = {
    Registration: string
    Owner: string
    Wheels: int
    customAttribute1: string
    customAttribute2: string
}

type Truck = {
   Registration: string
   Owner: string
   Wheels: int
   customField5: string
   customField6: string
}

type Bike = {
    Owner: string
    Color: string
}


type Vehicle = {
    Registration: string
    Owner: string
    VehicleType: System.Type
}

let inline someComplexFun v  =
   let t = typeof< ^v>
   let owner =  (^v: (member Owner: string)(v)) 
   let registration = (^v: (member Registration: string)(v))
   {Registration = registration; Owner = owner; VehicleType = t}

let car = {Car.Registration = "xyz"; Owner = "xyz"; Wheels = 3; customAttribute1= "xyz"; customAttribute2 = "xyz"}
let truck = {Truck.Registration = "abc"; Owner = "abc"; Wheels = 12; customField5 = "abc"; customField6 = "abc"}
let bike = {Owner = "hell's angels"; Color = "black"}
someComplexFun car
someComplexFun truck
//someComplexFun bike



open System

type Document = {
    Name: string
    Version: string
}

type OtherDoc = {
    Name: string
    Version: string
}

// let inline requestData< ^a when ^a : (member Name : string)  > x =
//     Console.WriteLine(^a: (member Name: string)(x))


let inline requestData< ^a when ^a : (member Name : string) and ^a : (member Version : string) > x =
    Console.WriteLine(^a: (member Name: string)(x))
    Console.WriteLine(^a: (member Version: string)(x))

let doc1 = {Document.Name = "Joe"; Version = "123"}
let doc2 = {OtherDoc.Name = "Jim"; Version = "456"}


requestData doc2
requestData doc1

requestData<Document> doc1
requestData<OtherDoc> doc2

//requestData<Document> doc2



type IVehicle =
    abstract Registration : string
    abstract Owner : string

let carPrinter (c: Car) =
    {new IVehicle with 
     member __.Registration = c.Registration
     member __.Owner = c.Owner}

let truckPrinter (t: Truck) =
    {new IVehicle with
    member __.Registration = t.Registration
    member __.Owner = t.Owner}

let vehiclePrinter (v: IVehicle) =
    (v.Registration,v.Owner)

let printer (printer: 'a -> IVehicle) v =
    (printer v) |> vehiclePrinter

printer carPrinter car
printer truckPrinter truck


let (|Cars|_|) x =
    match x with 
    | {Car.Registration = _; Owner = _; Wheels = _; customAttribute1 = _; customAttribute2 = _} -> Some(x.Registration, x.Owner)
    | _ -> None
 
let (|Other|_|) x = 
    match x with 
    | {Truck.Registration =_ ; Owner = _; Wheels = _ ; customField5 = _; customField6 = _ } -> Some(x.Registration,x.Owner) 
type Wheels = Car | Truck

let getFields x  =
    match x with
    | Other z -> z
 
getFields truck

