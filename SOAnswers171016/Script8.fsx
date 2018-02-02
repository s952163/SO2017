open System
open System.IO
open System.Web.Configuration

let fileReplace (filename : string) (needle : string) (replace : string) : unit = 
        //use  file = IO.File.OpenText filename
        use  file = IO.File.OpenText filename  
        let lines = 
            [ 
              while not file.EndOfStream // runs through the file 
                do yield file.ReadLine().Replace(needle, replace)
            ]
        use writer = IO.File.CreateText filename // creates the file 
        for line in lines
            do writer.WriteLine line
        
let filename = @"C:\tmp\test3.txt"
let needle = "line" // given string already appearing in the text
let replace = "row" // Whatever string that needs to be replaced

fileReplace filename needle replace

<<<<<<< HEAD

///
type TesTRec = {
    Name: string
    Id: int option
    Codes: int[] option
}
=======
type EmployeeName =
    { First  : string
      Last   : string }

type MatcherInput =
    | Name of EmployeeName
    | EmployeeID of int
    | Info of string

let james = Name {First = "James"; Last = "Winklenaught"}
let ted = Name {First = "Theodore"; Last = "Chesterton"}

let LookupEmployee (input: MatcherInput)  =

    let numberLookup = 
            Map.ofList [(james, EmployeeID 1); (ted, EmployeeID 2)]

    let infoLookup = 
        Map.ofList [(EmployeeID 1,Info "CEO");(EmployeeID 2,Info "CFO")]

    match input with 
    | Name n -> numberLookup.[Name n]
    | EmployeeID _  -> infoLookup.[input]
    | Info _ -> failwith "Dont match on Info"

LookupEmployee ted
LookupEmployee (EmployeeID 2)


>>>>>>> 30c1b52feeeed929acb58160c36a2bd79331c2ec
