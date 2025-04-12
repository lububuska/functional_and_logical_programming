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

    // 13 задание

    let list3 = [5; 3; 8; 1; 4]

    printfn "Оригинальный список: %A" list3

    let resultShiftLeftOneList = shiftLeftOneList list3

    printfn "Циклический сдвиг на 1 влево (list): %A" resultShiftLeftOneList

    let resultShiftLeftOneChurch = shiftLeftOneChurch list3

    printfn "Циклический сдвиг на 1 влево (Списки Чёрча): %A" resultShiftLeftOneChurch

    // 14 задание

    let list4 = [5; 3; 8; 1; 4]

    printfn "Оригинальный список: %A" list4

    let indicesList, countOfIndicesList = amountLessLeftElementList list4

    printfn "Индексы элементов, которые меньше своего левого соседа (list): %A" indicesList

    printfn "Количество элементов, которые меньше своего левого соседа (list): %A" countOfIndicesList

    let indicesChurch, countOfIndicesChurch = amountLessLeftElementChurch list4

    printfn "Индексы элементов, которые меньше своего левого соседа (Списки Чёрча): %A" indicesChurch

    printfn "Количество элементов, которые меньше своего левого соседа (Списки Чёрча): %A" countOfIndicesChurch

    // 15 задание

    let list5 = [5; 3; 8; 1; 12]

    printfn "Оригинальный список: %A" list5

    let divisorsList = findDivisorsList list5

    printfn "Положительные делители элементов списка (list): %A" divisorsList

    let divisorsChurch = findDivisorsChurch list5

    printfn "Положительные делители элементов списка (Списки Чёрча): %A" divisorsChurch

    0