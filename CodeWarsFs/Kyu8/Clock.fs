module CodeWarsFs.Kyu8.Clock
let past h m s = h * 60 |> fun min -> (min + m) * 60 |> fun sec -> (sec + s) * 1000


