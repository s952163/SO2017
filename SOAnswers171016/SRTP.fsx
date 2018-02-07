open System

type Circle = Circle of radius:double
type Rectangle = Rectangle of width:double * length:double

type CircleShape() =
    member this.Area(Circle(radius)) = Math.PI * Math.Pow(radius, 2.)
let circleShape = CircleShape()

type RectangleShape() =
    member this.Area(Rectangle(width, length)) = width * length
let rectangleShape = RectangleShape()

let inline areaOf shapeImpl shape =
    ( ^T : (member Area : 'A -> double) (shapeImpl, shape))

let rectangle = Rectangle(10.0, 10.0)
let circle = Circle(10.0)
areaOf rectangleShape rectangle
areaOf circleShape circle

type MyRec1 = {
    Name: string
    Address: string
}

type MyRec2 = {
    Address: string
    CodeName: int
}

let rec1 = {Name = "Joe"; Address = "NYC"}
let rec2 = {Address = "LA"; CodeName = 202}

type IGetAddress<'a> =
    abstract member ShowAddress:  string

let ShowAddress1 (x:MyRec1) =
    { new IGetAddress<_> with 
        member __.ShowAddress =  x.Address }

let ShowAddress2 (x: MyRec2) =
    { new IGetAddress<_> with
        member __.ShowAddress = x.Address }

let showAddress (impl: 'a -> IGetAddress<'a>) x = (impl x).ShowAddress

showAddress ShowAddress1 rec1
showAddress ShowAddress2 rec2

let mk1 x : IGetAddress<MyRec1> = ShowAddress1 x
let mk2 x : IGetAddress<MyRec2> = ShowAddress2 x 

let x1 = mk1 rec1
let x2 = mk2 rec2 

x1.ShowAddress
x2.ShowAddress

let showAddressSimple (x: IGetAddress<'a>) = x.ShowAddress 

showAddressSimple x1
showAddressSimple x2

type DUAddress =
    | MyRec1 of MyRec1
    | MyRec2 of MyRec2

type TestDU =
    | Blah of string
    | Foo of int
    member __.Adddress = "Hello"

let b1 = Blah "oops"

let b2 = Foo 10

b1.Adddress
b2.Adddress