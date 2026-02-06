module MathOperations

// Basic math functions
let add x y = x + y
let subtract x y = x - y
let multiply x y = x * y
let divide x y = x / y

// Factorial using recursion
let rec factorial n =
    if n <= 1 then 1
    else n * factorial (n - 1)

// Fibonacci sequence
let rec fibonacci n =
    match n with
    | 0 -> 0
    | 1 -> 1
    | _ -> fibonacci (n - 1) + fibonacci (n - 2)

// Check if number is prime
let isPrime n =
    if n <= 1 then false
    else
        let limit = int (sqrt (float n))
        [2..limit] |> List.forall (fun i -> n % i <> 0)

// Main entry point
[<EntryPoint>]
let main argv =
    printfn "Math Operations in F#"
    printfn "======================"
    
    printfn "5 + 3 = %d" (add 5 3)
    printfn "10 - 4 = %d" (subtract 10 4)
    printfn "6 * 7 = %d" (multiply 6 7)
    printfn "15 / 3 = %d" (divide 15 3)
    
    printfn "\nFactorial of 5 = %d" (factorial 5)
    printfn "Fibonacci(7) = %d" (fibonacci 7)
    
    printfn "\nPrime numbers check:"
    [2..20] 
    |> List.filter isPrime
    |> List.iter (fun n -> printf "%d " n)
    printfn ""
    
    // Alternative: using pipe operator
    printfn "\nUsing pipeline:"
    10 |> factorial |> printfn "Factorial of 10 = %d"
    
    0 // Return success code