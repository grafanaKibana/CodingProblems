module CodeWarsFs.Kyu7.UnluckyDays

open System

let unluckyDays year =
    [1..12]
    |> Seq.filter(fun month -> DateTime(year, month, 13).DayOfWeek = System.DayOfWeek.Friday)
    |> Seq.length