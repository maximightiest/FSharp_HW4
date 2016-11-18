
module AST

type typeExpr = 
  | TVar of string                 // Type variable. Ex: 'a, 'b, 'element 
  | ArrowT of typeExpr * typeExpr  // Arrow type. Ex: 'a -> int, 'a -> ('b list), (int -> bool) -> int
  | ProdT of typeExpr * typeExpr   // Product type. Ex:, 'a * 'b,  int * (int -> int),  (int * int) * int
  | BasicT of string               // Basic type. Ex: int, bool, float 
  | ParT of string * typeExpr list // Parametric type. Ex: 'a list, string list, ('a, 'b) map

