module Parser
open FParsec

//тип выражения
type Expression =
    | Number of int
    | Op of string * Expression * Expression

// пробелы
let ws = spaces

// число
let pNumber = pint32 .>> ws |>> Number

// объявляем выражение
let expr, exprRef = createParserForwardedToRef<Expression, unit>()

// обработка скобок
let pParenExpr = between (pstring "(" .>> ws) (pstring ")" .>> ws) expr

// либо число, либо выражение в скобках
let pTerm = pNumber <|> pParenExpr

// операции с приоритетами
let opp = new OperatorPrecedenceParser<Expression, unit, unit>()
let pExpr = opp.ExpressionParser
opp.TermParser <- pTerm

let binOp sym prio = InfixOperator(sym, ws, prio, Associativity.Left, fun a b -> Op(sym, a, b))

opp.AddOperator(binOp "+" 1)
opp.AddOperator(binOp "-" 1)
opp.AddOperator(binOp "*" 2)
opp.AddOperator(binOp "/" 2)

exprRef := pExpr

// главный парсер
let pProgram = ws >>. expr .>> eof

let parse input =
    match run pProgram input with
    | Success(result, _, _) ->
        printfn "Разбор успешен: %A" result
        Some result
    | Failure(msg, _, _) ->
        printfn "Ошибка:\n%s" msg
        None