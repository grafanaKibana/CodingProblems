module CodeWarsFs.Kyu8.RemoveExclamationMarks

open System
open Microsoft.FSharp.Core

let removeExclamationMarks s =
    s.ToString().ToCharArray()
    |> Array.filter (fun sym -> sym <> '!')
    |> fun arr -> String.Join("", arr)