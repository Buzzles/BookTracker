namespace Api.Controllers

open Microsoft.AspNetCore.Mvc

[<Route("api/[controller]")>]
[<ApiController>]
type TestController () =
    inherit ControllerBase()

    [<HttpGet>]
    member this.Get() =
        let msg = "Bonjour to BookTracker"
        ActionResult<string>(msg)