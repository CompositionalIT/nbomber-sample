# NBomber sample
This repository contains two applications that should be run side-by-side:

1. `app`, a simple ASP .NET Core web application that returns the text `Hello World!` for every request (regarding of route or verb).
2. `testrig`, an NBomber test application which hits the `http://localhost:5000` (which is the default for ASP .NET Core applications).