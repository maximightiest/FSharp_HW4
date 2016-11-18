


(* Parser/lexer generation, Windows

   cd H:\Desktop\Hw4\Logo
   ..\bin\fslex --unicode Lexer.fsl
   ..\bin\fsyacc --module Parser Parser.fsy
*)



#r "System.Drawing.dll"
#r "System.Windows.Forms.dll"


// Windows only
#r "C:\Users\Max\Desktop\Hw4\\bin\FsLexYacc.Runtime.dll"
#load "C:\Users\Max\Desktop\Hw4\Logo\AST.fs" 
#load "C:\Users\Max\Desktop\Hw4\Logo\Parser.fs"
#load "C:\Users\Max\Desktop\Hw4\Logo\Lexer.fs" 
#load "C:\Users\Max\Desktop\Hw4\Logo\Parse.fs" 


// MacOs only
//#r "/Users/tinelli/Desktop/Hw4/bin/FsLexYacc.Runtime.dll"
//#load "C:\Users\Max\Desktop\Hw4\Logo\AST.fs" 
//#load "C:\Users\Max\Desktop\Hw4\Logo\Parser.fs"
//#load "C:\Users\Max\Desktop\Hw4\Logo\Lexer.fs" 
//#load "C:\Users\Max\Desktop\Hw4\Logo\Parse.fs" 
//#load "C:\Users\Max\Desktop\Hw4\Logo\Logo.fs" 


open AST

let c = "{repeat 10 {right 36; repeat 5 {forward 54; right 72}}}"
let p1 = Parse.fromString c

Logo.execute p1

let c1 = "
{
  repeat 10 {
   right 36; 
   repeat 5 {
    forward 54; 
    right 72
   }
  }
}"

let p2 = Parse.fromString c1

// p1 should be the same as p2


// executing directly abstract syntax
Logo.execute [Repeat (10, [Right 36; Repeat (5, [Forward 54; Right 72])])]

Logo.execute [F 36; R 90; F 66; L 90; Forward 20]







