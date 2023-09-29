# Exercise 6.5

## 1 Using the type inference function  

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

TODO

## 2 Micro-ML programs

### bool -> bool

```{ML}
let f x = x = true in f end
```

### int -> int

```{ML}
let f x = x + 0 in f end
```

### int -> int -> int

```{ML}
let g y = let f x = x+y in f end in g end
```

### 'a -> 'b -> 'a

```{ML}
let g y = let f x = y in f end in g end
```

### 'a -> 'b -> 'b

```{ML}
let g y = let f x = x in f end in g end
```

### ('a -> 'b) -> ('b -> 'c) -> (a' -> 'c)

```{ML}
let compose f = let inner g = let argument x = g (f (x)) in argument end in inner end in compose end
```

This is an implementation of the >> / compose function in F#.

### 'a -> 'b

```{ML}
let f x = f x in f end
```

### 'a

```{ML}

```
