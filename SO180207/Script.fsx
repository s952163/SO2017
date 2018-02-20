#load "TestModule.fs"
open System

open TestModule

MyModule.testFunc


let inline f t = (^T : (member Id:int) t)

type MyRec1 = {
    Id: int
    Name: string 
    }

type MyClass(id: int, address: string) = 
    member __.Id = id
    member __.Address = address 

let myrec1 = {Id=100; Name= "jim"}
let myclass = MyClass(id=99, address = "NYC")

f myrec1
f myclass 