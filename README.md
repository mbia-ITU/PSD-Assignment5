# Assignment 05

Solved by the group Recursive Rebels.

## Exercises

PLC: 5.1, 5.7, 6.1, 6.2, 6.3, 6.4 and 6.5

## Run instructions

```{}
fslex --unicode <LexerSpecification>.fsl
fsyacc --module <ParserName> <ParserSpecification>.fsy
dotnet fsi -r FsLexYacc.Runtime.dll ...
```

On MacBook

```{}
mono ~/bin/fsharp/fslex.exe --unicode <LexerSpefication>.fsl
mono ~/bin/fsharp/fsyacc.exe --module <ParserName> <ParserSpecification>.fsy
dotnet fsi -r FsLexYacc.Runtime.dll ...
```

## Handin details

Handin file name:

- BPRD-05-AMDH-EMNO-MBIA.zip

Files to handin:

- Exercise6.1.md
- Exercise6.4.md
- Exercise6.5.md
- Type1.png
- Type2.png
- MergeF/Merge.fs
- MergeC/Merge.cs
- TypedFun/TypedFun.fs
- Fun/TypeInference.fs
- Fun/FunLex.fsl
- Fun/FunPar.fsy
