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