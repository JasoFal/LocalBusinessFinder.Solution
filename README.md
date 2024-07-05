# _Local Business Lookup_

#### By _**Jason Falk**_

#### _A Fidgetech project._

## Technologies Used

* _Html/C#/Bootstrap_
* _MySql Workbench_
* _Dotnet_
* _Postman_

## Description

_Local Business Lookup is an app that displays and stores information about local stores and restaurants. This app uses Cross-Origin Resource Sharing (CORS). CORS is an HTTP-header based mechanism that allows a server to indicate any origins (domain, scheme, or port) other than its own from which a browser should permit loading resources._

## Documentation

GET: https://localhost:5000/Businesses
| Parameter |  Type  | Required | Description |
|:-----|:--------:|:------:|-------: |
| pagenumber   | int | required | Returns page matching pagenumber |
| type   |  string  |   not required | Returns businesses with a matching type value |


GET https://localhost:5000/Businesses?pagenumber=2
GET https://localhost:5000/Businesses?type=restaurant
----

GET: https://localhost:5000/businesses/7
| Parameter |  Type  | Required | Description |
|:-----|:--------:|:------:|-------: |
| id | int | required | Returns message matching id |

---

POST: https://localhost:5000/businesses

``When making a POST request to http://localhost:5000/api/Businesses/, you need to include a body. Here's an example body in JSON:``

```JSON
{
  "Name": "string",
  "Type": "string",
  "Description": "string"
}
```

---

PUT: https://localhost:5000/Businesses/20

``When making a PUT request to http://localhost:5000/Businesses/, you need to include a body. Here's an example body in JSON:``
```JSON
{
  "Name": "string",
  "Type": "string",
  "Description": "string"
}
```
| Parameter |  Type  | Required | Description |
|:-----|:--------:|:------:|-------: |
| id | int | required | Returns message matching id |

----

DELETE: https://localhost:5000/Businesses/7

| Parameter |  Type  | Required | Description |
|:-----|:--------:|:------:|-------: |
| id | int | required | Returns message matching id |

-----

## Setup/Installation Requirements

1. _Open Git Bash/Open the terminal of your choice navigate to the directory of your choice and run this command `git clone https://github.com/JasoFal/LocalBusinessFinder.Solution.git`_
2. _Once you have cloned the project, navigate to the project folder using Git Bash/ a terminal of your choice using the `cd` command and run `code .` within the project folder. Alternatively, you can use VSCodes (You can use any editor but these instructions are for VSCode) open the folder option under the File tab to open the project manually shortcut is `Ctrl + O`_

##### Installing Dependencies

3. _Navigate to the project directory, in this case, **LocalBusinessLookup** using the command `cd LocalBusinessLookup` in the terminal._
4. _Then once in the LocalBusinessLookup directory, run: `dotnet restore` and `dotnet build`._

##### Setting up database

5. _Within the **LocalBusinessLookup** directory create a file named appsettings.json._
6. _Copy and paste example code below to your appsettings.json adding your UserID and Password (Brackets [] not needed when adding UserId and Password)._
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=localbusinesslookup;uid=[UserId];pwd=[Password];"
  }
}
```
7. _Run `dotnet ef database update` to create a database._

##### To run the project do the following:
1. _To run the app type `dotnet watch run` in the terminal within **LocalBusinessLookup** directory._
* _Then using a browser of your choice enter https://localhost:5000/swagger/index.html into the search bar._
* _This should bring you to a swagger page displaying documentation info and the ability to test api endpoints_
* _Alternatively use **Postman** to test api endpoints._

## Known Bugs

* _No known bugs._

## License

_MIT License_

Copyright (c) 7/5/2024 Jason Falk

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.