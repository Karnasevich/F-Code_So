open System

let square x = x * x

let absValue x =
if x < 0 then -x
else x

let maxOfTwo a b =
if a > b then a
else b

let rec factorial n =
if n <= 1 then 1
else n * factorial (n - 1)

let rec fib n =
if n <= 1 then n
else fib (n - 1) + fib (n - 2)

[]
let main argv =

let a = 5
let b = -3
let c = -10
let d = 7
let e = 4
let f = 9

printfn "square %d = %d" a (square a)
printfn "square %d = %d" b (square b)

printfn "absValue %d = %d" c (absValue c)
printfn "absValue %d = %d" d (absValue d)

printfn "maxOfTwo %d %d = %d" e f (maxOfTwo e f)

let numbers = [1 .. 10]
let squares = List.map square numbers
let evens = List.filter (fun x -> x % 2 = 0) numbers
let sum = List.fold (fun acc x -> acc + x) 0 numbers

printfn ""
printfn "numbers = %A" numbers
printfn "squares = %A" squares
printfn "evens = %A" evens
printfn "sum = %d" sum

printfn ""
printfn "factorial 0 = %d" (factorial 0)
printfn "factorial 1 = %d" (factorial 1)
printfn "factorial 5 = %d" (factorial 5)
printfn "factorial 7 = %d" (factorial 7)
printfn "factorial 10 = %d" (factorial 10)

printfn ""
printfn "fib 0 = %d" (fib 0)
printfn "fib 1 = %d" (fib 1)
printfn "fib 5 = %d" (fib 5)
printfn "fib 7 = %d" (fib 7)
printfn "fib 10 = %d" (fib 10)

0