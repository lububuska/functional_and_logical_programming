module Agent
open System

type AgentMessage =
    | Print of string
    | ShowTime
    | Add of int * int
    | Exit 

let agent = MailboxProcessor.Start(fun inbox ->
    let rec loop () = async {
        let! msg = inbox.Receive()
        match msg with
        | Print text ->
            printfn "Сообщение: %s" text
            return! loop()
        | ShowTime ->
            let now = DateTime.Now
            printfn "Текущее время: %s" (now.ToString("HH:mm:ss"))
            return! loop()
        | Add (x, y) ->
            let result = x + y
            printfn "Сумма: %d" result
            return! loop()
        | Exit ->
            printfn "Агент завершает работу."
    }
    loop ()
)