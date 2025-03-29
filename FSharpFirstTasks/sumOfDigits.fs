module sumOfDigits
open System

// Рекурсия вверх
let sumOfDigitsDown n =
    let rec sumOfDigitsDown1 n curSum =
        if n = 0 then curSum
        else
            let n1 = n / 10
            let cifr = n % 10
            let newSum = curSum + cifr
            sumOfDigitsDown1 n1 newSum
    sumOfDigitsDown1 n 0

let result = sumOfDigitsDown 12345
printfn "Сумма цифр: %d" result

// Рекурсия вниз
let rec sumOfDigitsUp n =
    if n = 0 then 0
    else (n%10) + (sumOfDigitsUp (n / 10))

let result2 = sumOfDigitsUp 12345
printfn "Сумма цифр: %d" result2

// Хвостовая рекурсия 
let rec sumOfDigitsTailRec (n: int, acc: int) : int =
    if n = 0 then acc                               
    else sumOfDigitsTailRec (n / 10, acc + n % 10)    

let sumOfDigits n = sumOfDigitsTailRec (n, 0)

// Пример использования
let result3 = sumOfDigits 12345 
printfn "Сумма цифр: %d" result3