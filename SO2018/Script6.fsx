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

