namespace ReportController

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open Report

[<ApiController>]
[<Route("[controller]")>]
type ReportController (logger : ILogger<ReportController>) =
    inherit ControllerBase()

    [<HttpGet>]
    member _.Get() =
        { Date = DateTime.Now
          ReportText = "Test is the best"}
