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

The fist expression that fails, is due to circularity of the type.
The parameter `g` must be a function.
However it is called with itself as parameter.
Hence its type can't be derived as it must take take itself as parameter infinitely.

The second expression that fails, because there are two different types in the expression.
The problem is that the expression `if true then y else x` makes `x` and `y` the same type.
Then, when `g false` is called, the type of `x` and `y` becomes `bool`.
Then the call `f 42` fails.

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

This is an implementation of the `>>` or compose function in F#.

### 'a -> 'b

```{ML}
let f x = f x in f end
```

### 'a

```{ML}
let f x = f x in f 1 end
```
