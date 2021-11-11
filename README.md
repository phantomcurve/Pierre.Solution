# Pierre's Delectables

#### A slick little web app for Pierre's bakery customers to browse his goods and be given the option to do so as registered users, no less!

#### By Tim Roth

## Description

This Epicodus project creates a C# MVC web app (for an exhausted fictional baker named Pierre) that is connected to a database to allow both guests and authenticated users to view all treats and flavors and ultimately allow authenticated users to have some creative control at the bakery.

## User Actions

* View splash page with a welcome message, lists of all current treats and flavors, and links to view standalone flavor and treat lists
* Select `See all flavors` link allows all users to view the current list of treats
* Select `Add New Flavor` link allows authenticated user to add a new flavor to the list
* Submitting new flavor redirects user to the `Flavors` index page
* Selecting an individual flavor shows all users a list of all treats of that flavor
* Selecting `See all treats` on `Index` or `Treat` page shows all treats (with clickable detail links) at the factory
* Selecting `Add Treat` link directs authenticated user to a form to add a treat
* Submitting new treat redirects user to `Treat` index page
* `Flavor` index page shows all users all flavors and their designated treat(s)
* Selecting an individual treat allows all users to view list of all flavors available for that treat
* Selecting `Edit Flavor` or `Edit Treat` allows authenticated user to add new or additional pairings for that flavor or treat
* Deleting a flavor from a treat or a treat from a flavor does not delete anything other than the association between the two

## Technologies Used

* C#
* ASP.NET&#8203; Core
* Razor
* MySQL Workbench
* Markdown // Dillinger
* VS Code
* Terminal
* Github
* Entity
* Identity

## Setup/Installation Requirements

### Prerequisites

* [.NET](https://dotnet.microsoft.com/)
* A code editor–we prefer [VS Code](https://code.visualstudio.com/)
* [MySQL WorkBench](https://dev.mysql.com/downloads/workbench/)

### Installation

1. Open terminal on your machine
2. Clone the repository: `git clone https://github.com/phantomcurve/Pierre.Solution`
3. Navigate to the `/Pierre` directory
4. Open with your preferred text editor to view the code

### appsettings.json configuration

1. Navigate to `/Pierre` directory in VSCode
2. Create a file in this directory called `appsettings.json`
3. In this file add the following: 
``{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[firstname_lastname];uid=root;pwd=[YOUR PASSWORD HERE & DELETE THESE SQUARE BRACKETS!];"
  }
}``

### Run the Program – using .NET EF Core Code-First Setup

1. Make sure you have navigated to the `/Pierre` directory
2. Make sure you have the MySql Workbench application open and that the server is running
3. Run `dotnet restore`
4. Run `dotnet build`
5. Run `dotnet ef database update`
6. Start the program with `dotnet run`
7. Open http://localhost:5000/ in your preferred browser
8. To create a user account, navigate to `My Account` link on the homepage
9. Enter an e-mail and password, currently there are no rules for your entries as long as you input something!
10. Click `Register`
11. Click the `Log in` button and enter the email and password you just used to register
12. Enjoy your new powers!
13. To log out, from anyhwere on the website, click `My Account` in the header and you will see a `Log out` link, which is entirely clickable and will indeed log you out!

### Manual MySQL and MySQL Workbench Configuration (if you like working harder, not smarter)
1. Download and install [MySQL](https://dev.mysql.com/downloads/file/?id=484914) by selecting `No thanks, just start my download`
2. Follow along with Installer until reaching `Configuration` page
3. Select `Use Legacy Password Encryption`
4. Set password as desired 
5. Click `Finish`
6. Open Terminal and enter command `echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`
7. Type `source ~/.bash_profile` to verify successful MySQL installation
8. Download and install [MySQL WorkBench](https://dev.mysql.com/downloads/workbench/)
6. Open MySQL Workbench and select Administration tab in upper left of navigator window
7. Select `Data Import/Restore` 
8. Select `Import from Self-Contained File`
9. Navigate to `Pierre.Solution` folder and select `tim_roth.sql`
10. With the `Default Schema to be Imported To` dropdown menu, select `New`
11. Name your new schema `firstname_lastname` and click `ok`
12. Click `Start Import` at bottom right of navigator window

## Known Bugs

* User can add multiple join relationships between treats and flavors

## Contact Information

* Tim Roth [timdroth@gmail.com](mailto:timdroth@gmail.com)

## License

* MIT License 
Copyright (C) [2021] [Tim Roth]
Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:
The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.