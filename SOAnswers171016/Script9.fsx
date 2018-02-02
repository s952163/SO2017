type EmployeeName =
    { First  : string
      Last   : string }

type MatcherInput =
    | Name of EmployeeName
    | EmployeeID of int

type MatcherOutput<'a> = 
    | Other of 'a
    | Info of string

let james = Name {First = "James"; Last = "Winklenaught"}
let ted = Name {First = "Theodore"; Last = "Chesterton"}

let LookupEmployee (input: MatcherInput) =

    let numberLookup = 
            Map.ofList [(james, EmployeeID 1); (ted, EmployeeID 2)]

    let infoLookup = 
        Map.ofList [(EmployeeID 1,Info "CEO");(EmployeeID 2,Info "CFO")]

    match input with 
    | Name _ -> Other (numberLookup.[input])
    | EmployeeID _ ->  infoLookup.[input]

let x = EmployeeID 1

LookupEmployee ted
LookupEmployee x