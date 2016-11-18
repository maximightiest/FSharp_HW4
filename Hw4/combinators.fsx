(*
   CS:3820 Programing Language Concepts
   
   Homework 4

   Team:  Max Riley
*)


(* Problem Set 1 *)

(* even : int -> bool *)
let even x = (x / 2) * 2 = x

(* map: ('a -> 'b) -> 'a list -> 'b list *)
let rec map f l = 
  match l with
    | []     -> []
    | h :: t -> (f h) :: (map f t)


(* (foldL f x [x1; ...; xn])
   = (f (... (f (f x x1) x2) ...) xn)
*)
(* foldL : ('a -> 'b -> 'a) -> 'a -> 'b list *)
let rec foldL f x l =
  match l with
  | []     -> x
  | h :: t -> foldL f (f x h) t

(* (foldR f [x1; ...; xn] x)
   = (f x1 (f x2 (... (f xn x)...))))
*)
(* foldR : ('a -> 'b -> 'b) -> 'a list -> 'b -> 'b *)
let rec foldR f l x =
  match l with
  | []     -> x
  | h :: t -> f h (foldR f t x)

(* all : ('a -> bool) -> 'a list -> bool *)
let rec all p l = 
  match l with
  | []     -> true
  | h :: t -> (p h) && (all p t)

(* some : ('a -> bool) -> 'a list -> bool *)
let rec some p l = 
  match l with
  | []     -> false
  | h :: t -> (p h) || (some p t)

(* filter : ('a -> bool) -> 'a list -> 'a list *)
let rec filter p l = 
  match l with 
  | []     -> []
  | h :: t -> if (p h) then h :: (filter p t)
                       else (filter p t) 




(* vsum : (float * float) list -> float * float *)

let addt (x,y) (z,p) = (x+z, y+p)

let vsum l =
    match l with
    | [] -> (0,0)
    | _ -> foldL addt (0,0) l

(* length : ’a list -> int *)
let lenhelp x y = y + 1

let length l=
    match l with
    | [] -> 0
    | _ -> foldR lenhelp l 0

(* llength : ’a list list -> int list *)

let llenhelp l j=
    match l with
    | _ -> foldR lenhelp l 0::j

let llength l =
    match l with
    | [] -> [0]
    | _ -> foldR llenhelp l []

(* remove : ’a -> (’a list -> ’a list) when ’a : equality *)

let remhelp c= if c then false else true

let remove a l =
    match l with
    | [] -> []
    | _ -> let remhelp c = if c=a then false else true in filter remhelp l
    

(* lmin : ’a list -> ’a *)

let lminhelp a b = if a<b then a else b

let lmin l =
    match l with
    | [] -> failwith "empty list"
    | h::t -> foldR lminhelp l h

(* isIn : ’a -> (’a list -> bool) when ’a : equality *)

let isInHelp g = if g then true else false

let isIn x l =
    match l with
    | [] -> false
    | _ -> let isInHelp g = if g=x then true else false in
                some isInHelp l

(* leven : int list -> bool *)

let leven l =
    match l with
    | [] -> true
    | _ -> all even l

(* append : ’a list -> ’a list -> ’a list *)

let appendhelp l j = l::j

let append l j =
    match l with
    | [] -> j
    | _ -> foldR appendhelp l j

