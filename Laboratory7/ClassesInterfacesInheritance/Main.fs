open FiguresPart1
open FiguresPart2

// 1 часть
let printShape (shape: IPrint) =
    shape.Print()
 
let rectangle1 = new Rectangle(5.0, 3.0)
let square1 = new Square(4.0)
let circle1 = new Circle(2.5)
 
printfn "Вывод информации о фигурах:"
printShape rectangle1
printShape square1
printShape circle1
 
printfn "\nВывод через вызов ToString():"
printfn "%s" (rectangle1.ToString())
printfn "%s" (square1.ToString())
printfn "%s" (circle1.ToString())

// 2 часть

let rectangle2 = Rectangle (5.0, 3.0)
let square2 = Square 4.0
let circle2 = Circle 2.5
 
printfn "\nВывод через алгеьраический тип:"
printfn "Площадь прямоугольника: %A" (calculateArea rectangle2)
printfn "Площадь квадрата: %A" (calculateArea square2)
printfn "Площадь круга: %A" (calculateArea circle2)