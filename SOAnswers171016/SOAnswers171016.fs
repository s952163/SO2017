module SOAnswers171016
open System
open System.IO

let reverseLines f =
  File.ReadAllLines f
  |> Array.rev

[<EntryPoint>]
let main argv =
    let fName = //check how many arguments are passed and extract the filename if there is only one argument 
        match argv.Length with
        | 0 -> failwith "Please specify a file name!"
        | 1 -> argv.[0]
        | _ -> failwith "Too many parameters!"  //you could handle the two file parameter case here 
    
    match File.Exists(fName) with
    | true -> reverseLines fName |> Array.iter Console.WriteLine //we are just piping the reversed lines to the console
    | false -> failwith "File doesn't exist!"

    0 // return an integer exit code
