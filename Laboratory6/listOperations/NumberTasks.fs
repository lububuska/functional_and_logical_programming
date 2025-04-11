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