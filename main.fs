=module Assignment

// Problem 1
let rec prod (lst:int list) =
    if List.isEmpty lst
    then 0
    else List.head lst + prod (List.tail lst)
    

// Problem 2
let rec map f (lst:int list) =
    [] -> []
    |
// Problem 3
let rec odd (lst:int list) =
    x::xs -> []
     odd %2 
    

// Problem 4
let rec filter f lst =
    filter :: (f->Bool) -> [f] -> [f]

    
