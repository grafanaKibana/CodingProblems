module CodeWarsFs.Kyu7.MaximumTripletSum

let maxTriSum (nums: List<int>) =
    nums
    |> List.sortDescending
    |> List.distinct
    |> List.take 3
    |> List.sum