// Functions snipped from here:
// https://gist.github.com/theburningmonk/2071722

#r "System.Runtime.Serialization" 
open System
open System.IO
open System.Runtime.Serialization.Json
open System.Runtime.Serialization

// I changed these two lines from using ASCII to using UTF8,
// for UNICODE support. This is also what Microsoft's similar
// examples use.
let toString = System.Text.Encoding.UTF8.GetString
let toBytes (x : string) = System.Text.Encoding.UTF8.GetBytes x

let serializeJson<'a> (x : 'a) = 
    let jsonSerializer = new DataContractJsonSerializer(typedefof<'a>)
    use stream = new MemoryStream()
    jsonSerializer.WriteObject(stream, x)
    toString <| stream.ToArray()

let deserializeJson<'a> (json : string) =
    let jsonSerializer = new DataContractJsonSerializer(typedefof<'a>)
    use stream = new MemoryStream(toBytes json)
    jsonSerializer.ReadObject(stream) :?> 'a

// End of snip

[<CLIMutable>]
[<DataContract>]
type MyType = {
    [<DataMember>] name: string
    [<DataMember>] ``type``: string
    [<DataMember>] id: string
    }

let document = { name = "test"; ``type`` = "document"; id = "e3c7373c-f4bc-4ffa-9a01-7c7d9f83e4cf" }
let json = serializeJson<MyType> document
json // LINQPad output

let json2 = """{"id":"e3c7373c-f4bc-4ffa-9a01-7c7d9f83e4cf","name":"test","type":"document"}"""
let document2 = deserializeJson<MyType> json2
document2 // LINQPad output
//(MyType.name, MyType.``type`` , MyType.id)