#r "System.Runtime.Serialization" 
open System
open System.IO
open System.Runtime.Serialization.Json
open System.Runtime.Serialization

[<DataContract>]
[<CLIMutable>]
type Person = {
    [<DataMember(Name="Name") >]
    entityName: string 
    [<DataMember(Name="Type") >]
    entityType: string 
}

let person = {entityName = "ENTITY"; entityType ="TYPE"}


let  toJson<'t> (myObj:'t) =   
    let fs = new FileStream(@"C:\tmp\test.json",FileMode.Create)
    (new DataContractJsonSerializer(typeof<'t>)).WriteObject(fs,myObj)

toJson<Person> person

[<DataContract>]
type Person2 = {
    [<DataMember(Name="Name") >]
    entityName: Nullable<int> 
    [<DataMember(Name="Type") >]
    entityType: String
}

let p1 = { entityName =  Nullable(10); entityType = "John"}
let p2 = { entityName =  System.Nullable(); entityType = null}