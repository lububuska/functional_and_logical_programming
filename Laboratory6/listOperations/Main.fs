open System
open NumberTasks
 
[<EntryPoint>]
let main argv =
    // 11 задание
    let list1 = [5; 3; 8; 1; 4]

    printfn "Оригинальный список: %A" list1

    let resultShiftRightTwoList = shiftRightTwoList list1

    printfn "Циклический сдвиг на 2 вправо (list): %A" resultShiftRightTwoList

    let resultShiftRightTwoChurch = shiftRightTwoChurch list1

    printfn "Циклический сдвиг на 2 вправо (Списки Чёрча): %A" resultShiftRightTwoChurch

    // 12 задание
    let list2 = [5; 3; 8; 1; 4]

    printfn "Оригинальный список: %A" list2

    let result = replaceMaxAndMinList list2

    printfn "Смена минимального и максимального элементов (list): %A" result

    let result = replaceMaxAndMinChurch list2

    printfn "Смена минимального и максимального элементов (Списки Чёрча): %A" result

    0