open System
open System.Web.Hosting.RecycleLimitMonitor
open System.Drawing

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




 