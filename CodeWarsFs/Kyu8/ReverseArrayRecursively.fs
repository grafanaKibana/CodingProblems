module CodeWarsFs.Kyu8.ReverseArrayRecursively

let rec revR list =
  match list with
  | [] -> list
  | head :: tail -> (revR tail) @ [head]