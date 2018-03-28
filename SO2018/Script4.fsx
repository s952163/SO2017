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
}

let inline someComplexFun v  =
   let owner =  (^v: (member Owner: string)(v)) 
   let registration = (^v: (member Registration: string)(v))
   {Registration = registration; Owner = owner}

let car = {Car.Registration = "xyz"; Owner = "xyz"; Wheels = 3; customAttribute1= "xyz"; customAttribute2 = "xyz"}
let truck = {Truck.Registration = "abc"; Owner = "abc"; Wheels = 12; customField5 = "abc"; customField6 = "abc"}
let bike = {Owner = "hell's angels"; Color = "black"}
someComplexFun car
someComplexFun truck
//someComplexFun bike

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

type Wheels =
 | Truck
 | Car