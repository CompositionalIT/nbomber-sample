open NBomber.FSharp
open NBomber.Contracts
open NBomber.Contracts.Stats
open System.Net.Http
open System
open NBomber

let client = new HttpClient()

let step =
    Step.create (
        "My First Test",
        fun _ ->
            task {
                let! response = client.GetAsync "http://localhost:5000/"
                let! content = response.Content.ReadAsByteArrayAsync()

                return
                    if response.IsSuccessStatusCode then
                        Response.ok (content, int response.StatusCode)
                    else
                        Response.fail (response.ReasonPhrase, int response.StatusCode, content.Length)
            }
    )

Scenario.create "My First Scenario" [ step ]
|> Scenario.withoutWarmUp
|> Scenario.withLoadSimulations [ InjectPerSecRandom(100, 500, seconds 20) ]
|> NBomberRunner.registerScenario
|> NBomberRunner.run
|> ignore
