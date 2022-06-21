module CodeWarsFs.Kyu7.OrderedCountOfCharacters

open System
open System.Collections.Generic
open Microsoft.FSharp.Collections

let orderedCount (text : string) =
    text
    |> Seq.countBy(id)
    |> Seq.toList 