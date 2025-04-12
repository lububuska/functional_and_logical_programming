module StringAnalisys

// Вариант 7
// Задание 19. Дана строка, состоящая из символов латиницы. Необходимо проверить, образуют ли прописные символы этой строки палиндром.

let isUpperCasePalindrome str =
    let upperChars = str |> Seq.filter System.Char.IsUpper |> Seq.toArray
    let reversedUpperChars = Array.rev upperChars
    upperChars = reversedUpperChars

// Задание 20.	Отсортировать строки в порядке увеличения квадратичного отклонения между сред-ним весом ASCII-кода символа в строке и максимально среднего ASCII-кода тройки подряд идущих символов в строке

// среднее значение
let calculateMeanAscii (str: string) =
    let asciiValues = str |> Seq.map int
    let sum = Seq.sum asciiValues
    float sum / float (Seq.length asciiValues)

// максимальное среднее среди троек подряд идущих символов
let calculateMaxTripleMeanAscii (str: string) =
    let asciiValues = str |> Seq.map int |> Seq.toArray
    if Array.length asciiValues < 3 then
        calculateMeanAscii str
    else
        let triples = [for i in 0 .. (Array.length asciiValues - 3) do yield asciiValues.[i..i+2]]
        let means = triples |> List.map (fun triple -> float (Array.sum triple) / 3.0)
        means |> List.max

// квадратичное отклонение
let calculateQuadraticDeviation mean maxTripleMean =
    (mean - maxTripleMean) ** 2.0

// сортировка
let sortStringsByDeviation (strings: string list) =
    strings |> List.sortBy (fun s ->
        let mean = calculateMeanAscii s
        let maxTripleMean = calculateMaxTripleMeanAscii s
        calculateQuadraticDeviation mean maxTripleMean)