module CodeWarsFs.Kyu7.SumOfNumbers

let getSum a b = [| min a b .. max a b |] |> Array.sum