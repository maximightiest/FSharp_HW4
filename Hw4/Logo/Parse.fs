
(* Lexing and parsing of simple expressions using fslex and fsyacc *)

module Parse

open System
open System.IO
open System.Text
open Microsoft.FSharp.Text
open AST

(* Plain parsing from a string *)

let fromString (str : string) : command list =
    let lexbuf = Lexing.LexBuffer<char>.FromString(str)
    try 
      Parser.Main Lexer.Token lexbuf
    with 
      | exn -> let pos = lexbuf.EndPos 
               failwithf "%s near line %d, column %d\n" 
                  (exn.Message) (pos.Line+1) pos.Column
             

                  