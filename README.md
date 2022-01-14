# _Pierre's Savory & Sweet Treats_

#### By: _*Anna Pittman*_

#### _A C# web application that utilizes a many to many relationship, as well as authentication and authorization functionality._

## Technologies Used

* _C#_
* _.NET 5_
* _ASP.NET Core MVC_
* _Razor_
* _Git_
* _MySql and MySQL Workbench_

## Description

A website where users can add and view baked goods at a bakery, and the flavors that are associated with each bakery item. Users must create an account to be able to add, edit and delete treats and flavors. A many to many design is utilized to display the relationships between treats and flavors. 

## Setup/Installation Requirements

* Download [.NET5](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
* Download MySQL and MySQL Workbench

## Application Setup

* Clone this repository to your desktop using the command: `git clone https://github.com/an12346/pierre-savory-sweet.git`
* Navigate to the project directory: `cd Pierre.Solution`
* Then, navigate to the production file: `cd PierreTreat`
* Create a file named "appsettings.json" in the `PierreTreat` directory
* Add the following code to appsettings.json:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=best_restaurants_refactor;uid=[YOUR DATABASE];pwd=[YOUR PASSWORD];"
  }
}
```
* Add the name of your database and password to the appsettings.json file
* To update the databse, run the command: `$ dotnet ef database update`
* To download obj and bin files, run the command `$ dotnet restore` 
* To open the application in a web browser, run the command: `$ dotnet run`

## Known Bugs

* _No known bugs_

## License

_MIT License: https://opensource.org/licenses/MIT_

Copyright (c) _2021_ _Anna Pittman_