 open System
 
 type ModelArg = {
     Number: int
     Name: string
 }
 
 [<AbstractClass>]
 type IModel(modelArg: ModelArg) = 
    abstract member Number: int
    abstract member Name: string
    abstract member NameAndNum: string -> string
    default __.Number = modelArg.Number
    default __.Name = modelArg.Name


type ConcreteModel1(modelArg: ModelArg) =
    inherit IModel(modelArg)
    override __.Number = 42
    override __.NameAndNum(x: string) = "Hello" + x

type ConcreteModel2(modelArg: ModelArg) =
    inherit IModel(modelArg)

let modelArg1 = {Number=2; Name ="Joe"}
let modelArg2 = {Number=3; Name = "Jim"}

let getNumberAndName(x: IModel) =
    (x.Number, x.Name)

let model1 = ConcreteModel1(modelArg1)
let model2 = ConcreteModel2(modelArg2);;

getNumberAndName(model1);;
//val it : int * string = (2, "Joe")
getNumberAndName(model2)
//val it : int * string = (3, "Jim")

type BaseClass(modelArg: ModelArg) =
    member __.Number = modelArg.Number
    member __.Name = modelArg.Name

let baseclass =  BaseClass(modelArg1)

type SubClass(input: BaseClass) =
    member __.X = input

let subclass = SubClass(baseclass)
subclass.X.Name