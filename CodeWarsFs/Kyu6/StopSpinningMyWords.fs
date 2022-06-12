module CodeWarsFs.Kyu6.StopSpinningMyWords

open System

let spinWords (str : string) = 
    str.Split [|' '|]
    |> Array.map (fun x -> if x.Length >= 5 then String(x.ToCharArray() |> Array.rev) else x)
    |> String.concat " " 