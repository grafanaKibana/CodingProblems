module CodeWarsFs.Kyu8.Summation

let summation n = seq { for i in 0 .. n - 1 -> i + 1 } |> Seq.sum