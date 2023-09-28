Log of fsi, for exercise 6.1:

> let w = "let add x = let f y = x+y in f end in add 2 5 end";;
val w: string = "let add x = let f y = x+y in f end in add 2 5 end"

> let w' = w |> fromString |> run;;
val w': HigherFun.value = Int 7

> let q = "let add x = let f y = x+y in f end in let addTwo  = add 2 in addTwo 5 end end";;
val q: string =
  "let add x = let f y = x+y in f end in let addTwo  = add 2 in "+[16 chars]

> let q' = q |> fromString |> run;;
val q': HigherFun.value = Int 7

> let e = "let add x = let f y = x+y in f end in let addTwo  = add 2 in let x = 77 in addTwo 5 end end end";;
val e: string =
  "let add x = let f y = x+y in f end in let addTwo  = add 2 in "+[34 chars]

> let e' = e  |> fromString |> run;;
val e': HigherFun.value = Int 7

> let r = "let add x = let f y = x+y in f end in add 2 end";;
val r: string = "let add x = let f y = x+y in f end in add 2 end"

> let r' = r |> fromString |> run;;
val r': HigherFun.value =
  Closure
    ("f", "y", Prim ("+", Var "x", Var "y"),
     [("x", Int 2);
      ("add",
       Closure
         ("add", "x", Letfun ("f", "y", Prim ("+", Var "x", Var "y"), Var "f"),
          []))])

-------------------------------------
Result of the third:
Yes, the result is as expected.
Since the language uses statically bound variables, the value of x in x+y, refers to the function parameter 'x', not the value of 'x' in 'let x = 77'.

Result of the fourth:
The function is partially applied, and support Currying. It returns a function of type int -> int, rather than a int.
This is because the second int is not applied yet.
