module CodeWarsFs.Kyu8.SumWithoutHighestAndLowestNum
let sumArray array =
    match array with
    | None
    | Some [] -> 0
    | Some [x] -> 0
    | Some values -> (List.sum values) - (List.max values) - (List.min values)
