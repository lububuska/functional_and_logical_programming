module CircleCylinder
open System

let circleArea radius =
    Math.PI * radius * radius

let cylinderVolume_curry radius height =
    circleArea radius * height

let multiplyArea area height =
    area * height

let cylinderVolume_superpos height = circleArea >> (fun area -> multiplyArea area height)
