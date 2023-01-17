# Dr. Sillystringz's Factory

#### By Jennifer Holcomb

#### An application for factory manager to manage engineers, and the machines they are licensed to repair. (fictitious)

## Technologies Used

* C#
* .NET 6
* ASP.NET Core 6 MVC
* EF Core 6
* SQL
* mySQL
* LINQ
* Dotnet-ef

## Description

This application keeps track of factory machines, their status (operational or malfunctioning), the engineers working at the factory, what machines they are licensed to repair (as well as a list of engineers licensed to repair each machine), and whether the engineer is idle or currently working on a repair. There is CRUD capability for both machine and engineer.

## Setup/Installation Requirements

* Clone this repo to your workspace.
* Navigate to program directory  (Factory.Solution)
  * add .gitignore file to this directory
    * add bin, obj, appsettings.json to file
    * push this file to GitHub first
* Navigate to production directory (Factory)
  * Create a file appsettings.json
    * Add the following to appsettings.json,
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=factory;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
      }
    }
    * In appsettings.json, replace '[YOUR-USERNAME-HERE]' with your SQL username, and '[YOUR-PASSWORD-HERE]' with your SQL password
* In production directory, on command line run $ dotnet restore.
* To load application database with migrations, in production directory,
  run $ dotnet ef database update.
* In prooduction directory, run $ dotnet watch run in command line to  
  start project in development mode in watcher.
* Open brower to https://localhost:5001


## Known Bugs

* No known bugs. 
* If any issues are discovered, please email jenniferlholcomb@gmail.com


## License

MIT License

Copyright (c) 2023 Jennifer Holcomb

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
