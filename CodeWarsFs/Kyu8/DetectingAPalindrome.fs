module CodeWarsFs.Kyu8.DetectingAPalindrome

open System

let isPalindrom (s : string) =
    s.ToLower().ToCharArray()
    |> Array.rev
    |> String.Concat
    |> fun revStr -> revStr = s.ToLower()