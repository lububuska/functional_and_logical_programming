// Задание 18 
// Напишите программу, которая вводит с клавиатуры два
// непустых неубывающих массива целых чисел, и печатает те
// и только те элементы, которые встречаются в обоих массивах
// (пересечение множеств)
module ClassMassive

let intersectionNonDecreasingArrays (a: int[]) (b: int[]) : int[] = 
     let isNonDecreasing arr = arr |> Array.pairwise |> Array.forall (fun (a, b) -> a <= b)
     if not (isNonDecreasing a || isNonDecreasing b) then failwith "Массивы не являются неубывающими!"
     a |> Array.filter (fun x -> Array.contains x b) |> Array.distinct