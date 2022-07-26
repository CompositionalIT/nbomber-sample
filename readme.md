# NBomber sample
This repository contains two applications that should be run side-by-side:

1. `app`, a simple ASP .NET Core web application that returns the text `Hello World!` for every request (regardless of route or verb).
2. `testrig`, an NBomber test application which hits `http://localhost:5000` (the default location for ASP .NET Core applications).
