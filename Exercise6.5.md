# Exercise 6.5

## 1

> fromString "let f x = 1 in f f end" |> inferType ;;
val it: string = "int"

> fromString "let f g = g g in f end" |> inferType ;;
System.Exception: type error: circularity
...

> fromString "let f x = let g y = y in g false end in f 42 end" |> inferType ;;
val it: string = "bool"

> fromString "let f x = let g y = if true then y else x in g false end in f 42 end" |> inferType
System.Exception: type error: bool and int
...

> fromString "let f x = let g y = if true then y else x in g false end in f true end" |> inferTyp
val it: string = "bool"

### Explanations when it fails


## 2

Micro-ML programs:
