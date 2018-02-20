module MyModule.Types 

type Action =
    | Add of int
    | Update of int * string
    | Delete of string
