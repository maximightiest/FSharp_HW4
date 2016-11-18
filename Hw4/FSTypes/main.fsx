


(* Parser/lexer generation, Windows (replace "H" with actual disk name)

   cd H:\Desktop\Hw4\FSTypes
   ..\bin\fslex --unicode Lexer.fsl
   ..\bin\fsyacc --module Parser Parser.fsy
*)




// Windows only
#r "C:\Users\Max\Desktop\Hw4\\bin\FsLexYacc.Runtime.dll"
//#r "C:\User\Max\Desktop\Hw4\\bin\FsLexYacc.Runtime.dll"
#load "C:\Users\Max\Desktop\Hw4\FSTypes\AST.fs" 
#load "C:\Users\Max\Desktop\Hw4\FSTypes\Parser.fs"
#load "C:\Users\Max\Desktop\Hw4\FSTypes\Lexer.fs" 
#load "C:\Users\Max\Desktop\Hw4\FSTypes\Parse.fs" 


open AST

Parse.fromString "int -> int"

Parse.fromString "int -> bool -> int"

Parse.fromString "int * bool -> int"

Parse.fromString "int -> bool * int"

Parse.fromString "(int -> bool) * int"

Parse.fromString "int list"

Parse.fromString "'a list"

Parse.fromString "(int, bool) map"

Parse.fromString "('a, 'a) map"

Parse.fromString "int -> bool list"

Parse.fromString "(int -> bool) list"

Parse.fromString "'a * 'b list"





