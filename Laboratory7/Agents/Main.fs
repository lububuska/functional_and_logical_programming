open Agent
open System

[<EntryPoint>]
let main argv =
    agent.Post(Print "Привет, агент!")
    agent.Post(ShowTime)
    agent.Post(Print "Ещё одно сообщение")
    agent.Post(Add(5, 2))
    agent.Post(Exit)
    agent.PostAndAsyncReply(fun replyChannel ->
        replyChannel.Reply()
        Exit
    )
    |> Async.RunSynchronously
    Console.ReadKey() |> ignore
    0