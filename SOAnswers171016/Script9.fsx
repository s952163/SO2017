type EmployeeName =
    { First  : string
      Last   : string }

type EmployeeID =
    | EmployeeID of int

type MatcherInput =
    | Name of EmployeeName
    | ID of EmployeeID

type MatcherOutput = 
    | Info of string
    | ID of EmployeeID

let james = Name {First = "James"; Last = "Winklenaught"}
let ted = Name {First = "Theodore"; Last = "Chesterton"}

let LookupEmployee (input: MatcherInput) =

    let numberLookup = 
            Map.ofList [(james, EmployeeID 1); (ted, EmployeeID 2)]

    let infoLookup = 
        Map.ofList [(EmployeeID 1,Info "CEO");(EmployeeID 2,Info "CFO")]

    match input with 
    | Name n -> MatcherOutput.ID numberLookup.[Name n]
    | MatcherInput.ID x ->  (infoLookup.[x])

let x = MatcherInput.ID (EmployeeID 1)

LookupEmployee ted
LookupEmployee x