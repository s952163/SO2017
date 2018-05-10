 
 type ModelArg = {
     Number: int
     Name: string
 }
 
 type IModel(modelArg: ModelArg) = 
    abstract member Number: int
    abstract member Name: string
    default __.Number = modelArg.Number
    default __.Name = modelArg.Name

type ConcreteModel1(modelArg: ModelArg) =
    inherit IModel(modelArg)

type ConcreteModel2(modelArg: ModelArg) =
    inherit IModel(modelArg)

let modelArg1 = {Number=2; Name ="Joe"}
let modelArg2 = {Number=3; Name = "Jim"}

let getNumberAndName(x: IModel) =
    (x.Number, x.Name)

let model1 = ConcreteModel1(modelArg1)
let model2 = ConcreteModel2(modelArg2)

getNumberAndName(model1)
//val it : int * string = (2, "Joe")
getNumberAndName(model2)
//val it : int * string = (3, "Jim")

