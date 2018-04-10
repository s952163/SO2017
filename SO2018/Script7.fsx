<<<<<<< HEAD
let hold y z median c1 c2 =            
        if  ((y > median) && (z > median)) then (c1,c1)
        elif ((y <= median) && (z <= median)) then (c2,c2)
        else (y,z)
    
let holder xs median =
    xs |> List.map (fun (y,z) -> (hold y z median 10 20, hold y z median 10 20, hold y z median 10  20)) 
    
let xs = [(20,40);(1,2)]
let med = 10

holder xs med

xs
|> List.map (fun (x,y) ->
                          if x > 10 then (x , x)
                          elif y >= 10 then (y , y)
                          else (x,y) )
=======
// type CapturablePieces = Pawn | Knight | Bishop | Rook | Queen

// //type Pieces = CapturablePieces of Pawn | Knight | Bishop | Rook | Queen | King
// type Pieces = Capturable of CapturablePieces | King
// let x = Pawn
// let y = Capturable(Pawn)

// let z = King


type CapturablePieces = Pawn | Knight | Bishop | Rook | Queen

type Pieces =
    | Capturables of CapturablePieces
    | King

let z = Capturables Pawn

let (Capturables xx ) = z

let x1 = 
    async {
        let y = 2
        let z = 3
        let x = async { return (y + z) } 
        return! x
    } |> Async.RunSynchronously
>>>>>>> b68161ec0f7a46e0206eefa9c68aa191339d0b20
