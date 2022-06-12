module CodeWarsFs.Kyu7.GeometricProgressionSequence

open System

let geometricSequenceElements (a: int) (r: int) (n: int) =
    [a..n]
    |> List.scan (fun acc _ -> acc * r) a
    |> List.map string
    |> String.concat ", "