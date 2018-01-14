open System
open System.IO

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