module FiguresPart1
open System

type IPrint = 
    abstract member Print: unit -> unit

[<AbstractClass>]
type GeometricFigure() =
    abstract member Area: float

type Rectangle(w: float, h: float) =
    inherit GeometricFigure()
    member this.Width = w
    member this.Height = h
    override this.Area = this.Width * this.Height
    override this.ToString() = 
        sprintf "У прямоугольника со сторонами %A %A площадь равна: %A" this.Width this.Height this.Area

    interface IPrint with
         member this.Print() = printfn "%s" (this.ToString())

type Square(s: float) = 
    inherit Rectangle(s, s)
    override this.ToString() = 
        sprintf "У квадрата со стороной %A площадь равна: %A" this.Width this.Area

    interface IPrint with
         member this.Print() = printfn "%s" (this.ToString())

type Circle(r: float) = 
    inherit GeometricFigure()
    member this.Radius = r
    override this.Area = System.Math.PI * this.Radius * this.Radius
    override this.ToString() = 
        sprintf "У круга с радиусом %A площадь равна: %A" this.Radius this.Area

    interface IPrint with
        member this.Print() = printfn "%s" (this.ToString())