
module AST

type command =
  | Forward of int    // pixels
  | Left of int       // degrees
  | Right of int      // degrees
  | Repeat of int * command list
