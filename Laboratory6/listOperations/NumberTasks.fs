module NumberTasks

// Вариант 7, задания 7, 17, 27, 37, 47, 57

// 1.7	Дан целочисленный массив. Необходимо осуществить циклический сдвиг элементов массива вправо на две позиции.

let rec shiftRightTwoList list = 
    let n = List.length list                
    if n <= 2 then list                      
    else
        let tail = List.skip (n - 2) list   
        let head = List.take (n - 2) list  
        tail @ head  


let rec shiftRightTwoChurch list =
    let rec listLength acc list =
        match list with
        | [] -> acc
        | head :: tail -> listLength (acc + 1) tail
    let length = listLength 0 list
    if length <= 2 then list
    else
        let rec shift acc list =
            match list with
            | _ :: tail when listLength 0 list = 2 -> list @ acc
            | head :: tail -> shift (acc @ [head]) tail
        shift [] list

// 1.17 Дан целочисленный массив. Необходимо поменять местами минимальный и максимальный элементы массива.

let rec replaceMaxAndMinList list =
    match list with
    | [] -> []
    | _ ->
        let couples = List.mapi (fun i x -> (i, x)) list
        let minIndex, minValue = List.minBy snd couples
        let maxIndex, maxValue = List.maxBy snd couples

        list
        |> List.mapi (fun i x ->
            if i = minIndex then maxValue
            elif i = maxIndex then minValue
            else x
        )

let replaceMaxAndMinChurch list = 
    let rec MIN tailItems currentIndex minValue minIndex =
        match tailItems with
        | [] -> (minIndex, minValue)
        | x :: rest ->
            if x < minValue then
                MIN rest (currentIndex + 1) x currentIndex
            else
                MIN rest (currentIndex + 1) minValue minIndex

    let rec MAX tailItems currentIndex maxValue maxIndex =
        match tailItems with
        | [] -> (maxIndex, maxValue)
        | x :: rest ->
            if x > maxValue then
                MAX rest (currentIndex + 1) x currentIndex
            else
                MAX rest (currentIndex + 1) maxValue maxIndex
                
    let replaceItems list minIdx maxIdx minVal maxVal =
        let rec loop remaining index acc =
            match remaining with
            | [] -> acc
            | x :: xs ->
                let newValue =
                    if index = minIdx then maxVal
                    elif index = maxIdx then minVal
                    else x
                loop xs (index + 1) (acc @ [newValue])
        loop list 0 []

    match list with
    | [] -> failwith "Пустой список"
    | x :: tail -> 
        let (minIdx, minVal) = MIN tail 1 x 0
        let (maxIdx, maxVal) = MAX tail 1 x 0
        replaceItems list minIdx maxIdx minVal maxVal

// 1.27 Дан целочисленный массив. Необходимо осуществить циклический сдвиг элементов массива влево на одну позицию.

let rec shiftLeftOneList list = 
    let n = List.length list                
    if n <= 1 then list                      
    else
        let tail = List.tail list   
        let head = List.head list  
        tail @ [head]

let rec shiftLeftOneChurch list =
    let rec listLength acc list =
        match list with
        | [] -> acc
        | head :: tail -> listLength (acc + 1) tail
    let length = listLength 0 list
    if length <= 1 then list
    else
        let shift list =
            match list with
            | [] -> list
            | head :: tail -> tail @ [head]
        shift list