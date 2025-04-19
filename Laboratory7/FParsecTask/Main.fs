open Parser

[<EntryPoint>]
let main argv =
    let expressions = [
        "5 + 10"
        "2 * (3 + 8)"
        "12 / 7 - 3"
        "11 + 5 * 3"
    ]
    for exp in expressions do
        printfn "\nВход: %s" exp
        parse exp |> ignore
    0