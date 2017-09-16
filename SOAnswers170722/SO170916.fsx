///https://stackoverflow.com/questions/46249656/codewars-com-kata-categorize-new-member


let ageAndHandi = [[18; 20];[45; 2];[61; 12];[37; 6];[21; 21];[78; 9]]

let openOrSenior (xs:List<List<int>>) =
    xs 
    |> List.map 
       (fun (x:List<int>) -> if x.[0] >= 55 && x.[1] > 7 then "Senior" else "Open")

openOrSenior ageAndHandi //val it : string list = ["Open"; "Open"; "Senior"; "Open"; "Open"; "Senior"]


let openOrSenior2 xs =
    [for (x:List<int>) in xs do   
     if x.[0] >= 55 && x.[1] > 7 then yield "Senior" else yield "Open"]

openOrSenior2 ageAndHandi


type ClubMember = {   
    age: int
    handi: int
}

type MemberType = Open | Senior

let ageAndHandi2 = [{age=18;handi=20}
                    {age=45;handi=2}
                    {age=61;handi=12}]

let selectMember (mem:ClubMember) =
    match mem with 
    | x when (mem.age >= 55) && (mem.handi > 7)  -> Senior
    | _ -> Open

ageAndHandi2
|> List.map selectMember
