## Compiler error

This project fails to compile with an "impossible" compiler error somewhere in the `XmlDocWriter`

```
error FS0192 : internal error : impossible [\src\ImpossibleCompilerError\ImpossibleCompilerError.fsproj]

 Unhandled Exception: System.Exception: impossible
            at Microsoft.FSharp.Compiler.Tastops.typeEnc(TcGlobals g, FSharpList`1 gtpsType, FSharpList`1 gtpsMethod, TType ty)
            at Microsoft.FSharp.Primitives.Basics.List.map[T,TResult](FSharpFunc`2 mapping, FSharpList`1 x)
            at Microsoft.FSharp.Compiler.Tastops.XmlDocArgsEnc(TcGlobals g, FSharpList`1 gtpsType, FSharpList`1 gtpsMethod, FSharpList`1 argTs)
            at Microsoft.FSharp.Compiler.Tastops.XmlDocSigOfVal(TcGlobals g, String path, Val v)
            at Microsoft.FSharp.Compiler.Driver.XmlDocWriter.doValSig@512(TcGlobals tcGlobals, String ptext, Val v)
            at Microsoft.FSharp.Compiler.Driver.XmlDocWriter.doValSig@512-1.Invoke(String ptext, Val v)
            at Microsoft.FSharp.Primitives.Basics.List.iter[T](FSharpFunc`2 f, FSharpList`1 x)
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

Possibly, the type provider is generating code that puts the compiler into a bad state and the doc string tips the `XmlDocWriter` logic over the edge? 

### Testing environment and version info

* Operating System: Windows 10
* .NET framework: net452
* F# compiler: v4.0 (Visual Studio 2015)
* Fsharp.Core: 4.4.0.0
* FSharp.Data (2.2.5) (also fails with 2.3.0-beta2 )