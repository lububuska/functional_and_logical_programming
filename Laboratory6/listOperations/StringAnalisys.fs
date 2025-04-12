module StringAnalisys

// Вариант 7
// Дана строка, состоящая из символов латиницы. Необходимо проверить, образуют ли прописные символы этой строки палиндром.

let isUpperCasePalindrome str =
    let upperChars = str |> Seq.filter System.Char.IsUpper |> Seq.toArray
    let reversedUpperChars = Array.rev upperChars
    upperChars = reversedUpperChars