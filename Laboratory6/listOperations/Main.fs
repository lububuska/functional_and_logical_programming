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

    0