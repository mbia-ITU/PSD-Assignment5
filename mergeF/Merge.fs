
(* The runtime of this function belongs to O(n log n).
   There exists a variant that runs in constant time, 
   but this has not been implemented
*)
let merge tuple = 
    let first = fst tuple
    let second = snd tuple

    first @ second |> List.sort