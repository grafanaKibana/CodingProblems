module CodeWarsFs.Kyu8.GetNumberFromString

open System

let getNumberFromString (s : string) =
    s.ToCharArray()
    |> Array.filter Char.IsNumber
    |> String.Concat
    |> int