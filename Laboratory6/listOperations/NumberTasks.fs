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
            | head :: tail ->
                let newValue =
                    if index = minIdx then maxVal
                    elif index = maxIdx then minVal
                    else head
                loop tail (index + 1) (acc @ [newValue])
        loop list 0 []

    match list with
    | [] -> failwith "Пустой список"
    | head :: tail -> 
        let (minIdx, minVal) = MIN tail 1 head 0
        let (maxIdx, maxVal) = MAX tail 1 head 0
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

// 1.37 Дан целочисленный массив. Вывести индексы элементов, которые меньше своего левого соседа, и количество таких чисел.

let amountLessLeftElementList list =
    let indices = 
        list |> List.mapi (fun i x -> (i, x)) |> List.skip 1 |> List.filter (fun (i, x) -> x < list.[i - 1]) |> List.map fst
    indices, List.length indices

let amountLessLeftElementChurch list =
    let rec loop left currentIndex tailItems accIndices accCount =
        match tailItems with
        | [] -> (accIndices, accCount)
        | head :: tail ->
            match head < left with
            | true -> loop head (currentIndex + 1) tail (currentIndex :: accIndices) (accCount + 1)
            | false -> loop head (currentIndex + 1) tail accIndices accCount
    match list with
    | [] | [_] -> ([], 0)
    | head :: tail -> loop head 1 tail [] 0

// 1.47 Для введенного списка положительных чисел построить список всех положительных делителей элементов списка без повторений.

let findDivisorsList list =
    let divisors n =
        [1 .. n] |> List.filter (fun x -> n % x = 0)

    list |> List.collect divisors |> List.ofSeq |> List.distinct

let findDivisorsChurch list =
    let rec process input acc =
        match input with
        | [] -> acc
        | head :: tail ->
            let rec findDivs i max dacc =
                match i > max with
                | true -> dacc
                | false ->
                    match max % i = 0 with
                    | true -> findDivs (i + 1) max (i :: dacc)
                    | false -> findDivs (i + 1) max dacc

            let rec addUnique from toAcc =
                match from with
                | [] -> toAcc
                | head :: tail ->
                    let rec exists x lst =
                        match lst with
                        | [] -> false
                        | y :: ys -> if head = y then true else exists head ys
                    match exists head toAcc with
                    | true -> addUnique tail toAcc
                    | false -> addUnique tail (head :: toAcc)

            let divs = findDivs 1 head []
            let newAcc = addUnique divs acc
            process tail newAcc

    process list []

// 1.57 Для введенного списка найти количество таких элементов, которые больше, чем сумма всех предыдущих.

let countGreaterThanPrevSumList list =
    let sumsBefore =
        list |> List.scan (fun acc x -> acc + x) 0 |> List.take (List.length list)

    let pairs = List.zip list sumsBefore

    pairs |> List.filter (fun (x, sumBefore) -> x > sumBefore) |> List.length


let countGreaterThanPrevSumChurch list =
    let rec helper lst sum count =
        match lst with
        | [] -> count
        | head :: tail ->
            let newCount =
                match head > sum with
                | true -> count + 1
                | false -> count
            helper tail (sum + head) newCount
    helper list 0 0

