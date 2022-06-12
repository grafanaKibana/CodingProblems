module CodeWarsFs.Kyu8.BinaryToDecimal

open System
open Microsoft.FSharp.Core

let binToDec (s : string) =
    s.ToCharArray()
    |> Array.rev
    |> Array.mapi (fun i elem -> (int elem - int '0') * (pown 2 i))
    |> Array.sum