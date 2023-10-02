# Exercise 6.4

## i

Type derivation, see [Type1.jpg](Type1.jpg)

Explanation for why `f` is polymorphic.
The function `f` is polymorphic, because it is the most general type applicable.
The parameter is unused, and as such can be any type.

## ii

Type derivation, see [Type2.jpg](Type2.jpg)

Explanation for why `f` is not polymorphic.
It is not polymorphic, because the type derivation does not evaluate the function to a general type.
The parameter is used in a context that must be an integer, for the derivation to be true.

