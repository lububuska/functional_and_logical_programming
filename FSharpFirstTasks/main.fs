open CircleCylinder
open System

[<EntryPoint>]
let main argv =
    // Площадь круга и объем цилиндра
    let radius = Console.ReadLine() |> float
    let height = Console.ReadLine() |> float

    let volumeCylinderCurry = cylinderVolume_curry radius height
    Console.WriteLine("Объем цилиндра с каррированием: {0}", volumeCylinderCurry)

    let volumeCylinderSuperpos = cylinderVolume_superpos height radius
    Console.WriteLine("Объем цилиндра с суперпозицией: {0}", volumeCylinderSuperpos)

    0