open Saturn
open Giraffe
open Microsoft.Extensions.Hosting
open Microsoft.AspNetCore.Http

let routes = text "Hello World!"
let app = application { use_router routes }

run app
