open System
open System.IO
let students = @"C:\tmp\students.txt"
let newRec = [|"Constant,Dunham,X,99999,cdx@gmail.com,2.0"|]

students 
|> File.ReadAllLines
|> Array.append newRec
|> Array.sort
|> (fun x -> File.WriteAllLines(students,x))