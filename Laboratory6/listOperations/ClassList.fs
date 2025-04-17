// Задание 17.
// Для введенного списка построить новый список, который получен из
// начального упорядочиванием по параметру P(a), где
// P(a) – сумма делителей числа а, которые являются делителями хотя бы
// одного из элементов списка, стоящих на четных позициях и не являются
// делителями ни одного из элементов, которые меньше среднего
// арифметического данного списка.
module ClassList

let divisors n =
     [1..int (sqrt (float n))]
     |> List.filter (fun d -> n % d = 0)
     |> List.collect (fun d -> if d * d = n then [d] else [d; n / d])
let sortByDivisorsParam list =
     let avg = float (List.sum list) / float (List.length list)
     list
     |> List.sortBy (fun a ->
         divisors a
         |> List.filter (fun d ->
             list |> List.indexed |> List.exists (fun (i, x) -> i % 2 = 0 && x % d = 0) &&
             list |> List.forall (fun x -> float x >= avg || x % d <> 0))
         |> List.sum)