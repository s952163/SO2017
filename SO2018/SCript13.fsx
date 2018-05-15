
if true then "Yes" else "No";;

match true with
    | true -> "Yes"
    | _  -> "false"


let myif =
    function 
        | true -> "Yes"
        | _ -> "false"

true |> myif


let myif2 x = if x then "Yes" else "No"

true |> myif2