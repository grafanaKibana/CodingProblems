module CodeWarsFs.Kyu7.BasicSequencePractice

let sumOfN (n : int) : int list =
    match n with
        | n when n > 0 -> List.init (n + 2) (fun idx -> (idx * idx - idx) / 2)
        | n when n < 0 -> List.init (abs n + 2) (fun idx -> ((idx * idx - idx) / 2) * -1)
        | _ -> failwith "todo"
    |> List.skip 1
    //|> List.mapi (fun i elem -> elem + (i + i * i))