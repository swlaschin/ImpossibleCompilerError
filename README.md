## Compiler error

This project fails to compile with an "impossible" compiler error.

```
error FS0192 : internal error : impossible [\src\ImpossibleCompilerError\ImpossibleCompilerError.fsproj]
```


It seems to be a strange interaction between the FSharp.Data CSV type provider and the compiler in the file [`MyModule.fs`](src/ImpossibleCompilerError/MyModule.fs).

The error fails to occur if the "," is changed to something else ("|" say), implying that it is something to do with parsing the sample text.

```
type PropertyOperatingStatementTP = FSharp.Data.CsvProvider<sample,Separators=",",HasHeaders=true >
```

But strangely the error _also_ fails to occur if a triple slash comment is changed to a double slash comment!

```
/// Change this comment to a double slash and it compiles without error! 
let toUpdateCommand (source:PropertyOperatingStatementTP.Row)  =
    ()
```

Possibly, the type provider is generating code that puts the compiler into a bad state and the doc string tips it over the edge? 