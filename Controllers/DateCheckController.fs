namespace DateServer.Controllers

open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging


[<ApiController>]
[<Route("[controller]")>]
type DateCheckController (logger: ILogger<DateCheckController>) =
    inherit ControllerBase()

    [<HttpGet>]
    member _.Get(day) =
        logger.LogInformation("hit")
        //Replace "true and false" with a date check to see if today is indeed arbour day
        match day with
        | "arbour" -> "true"
        | _ -> "false"
