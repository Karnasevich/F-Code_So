open System

let power2 n = n * n

let getAbs n =
if n >= 0 then n
else n * -1

let bigger x y =
if x >= y then x
else y

[]
let main args =

let x1 = 5
let x2 = -3
let x3 = -10
let x4 = 7
let x5 = 4
let x6 = 9

printfn "power2 %d = %d" x1 (power2 x1)
printfn "power2 %d = %d" x2 (power2 x2)

printfn "getAbs %d = %d" x3 (getAbs x3)
printfn "getAbs %d = %d" x4 (getAbs x4)

printfn "bigger %d %d = %d" x5 x6 (bigger x5 x6)

let nums = [1..10]

let squaredNums =
    nums |> List.map power2

let evenNums =
    nums |> List.filter (fun n -> n % 2 = 0)

let total =
    nums |> List.sum

printfn ""
printfn "nums = %A" nums
printfn "squaredNums = %A" squaredNums
printfn "evenNums = %A" evenNums
printfn "total = %d" total

0