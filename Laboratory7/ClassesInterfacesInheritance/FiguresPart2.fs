module FiguresPart2

type GeometricFigure = 
    | Rectangle of width: float * height: float
    | Square of side: float
    | Circle of radius: float

let calculateArea (figure: GeometricFigure) : float =
    match figure with 
    | Rectangle(width, height) -> width * height
    | Square(side) -> side * side
    | Circle(radius) -> System.Math.PI * radius * radius