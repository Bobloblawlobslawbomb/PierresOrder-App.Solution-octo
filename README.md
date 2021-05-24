# Pierres Order App

#### A Brief Description. 
### By Giancarlo Vigneri
---
## Technologies Used

>* _CSS_
>* _C#_
>* _.NET 5 SDK_
>* _ASP.NET_
>* _Bootstrap_

---
## Description 
The program will present the user with a splash screen which allows the user to 'view vendors' or 'add a new vendor'. If view vendors is selected without first entering a vendor the user will be presented with a screen stating "No vendors have been added yet!" and be given the ability to navigate back to the begining splash screen. If the user decides to 'add a new vendor' they are then brought to a page which has a field for a vendor name, a vendor description, a button to submit both fields and two more links which are labeled 'back home' and 'back to vendors.' which do both stated actions. Once a vendor is 'added' the user may click on the name of the vendor and is given a new set of options after doing so. The last link option is to return to the main splash page, the penultimate option merely navigates back to the last page (the list of vendors). There is also a link to 'add a new order', this will bring the user to a page where they may enter information that represents "order title", "order description", "order price", and "order date" and a button to submit. Once submitted the user is shown the orders details and is given the options to add another order and to view all vendors. 

## Installation Requirements/Setup

### Requirements

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A command line interface like Terminal or GitBash to run and interact with the console app.

### Running the Program:
1) Clone the repository: "https://github.com/Bobloblawlobslawbomb/PierresOrder-App.Solution-octo"
2) Navigate to the 'PierresOrderApp.Solution/' directory on your computer
3) Open with your favorite text editor (Visual Studio Code, is a pretty sweet one)
4. To run the console app:
   - Navigate to `PierresOrderApp.Solution/PierresOrderApp` in your command line
   - Run the command `dotnet restore` to restore the dependencies that are listed in `PierresOrderApp.csproj`
   - Run the command `dotnet build` to build the project and its dependencies into a set of binaries
   - Finally, run the command `dotnet run` to run the project!
   - Note: `dotnet run` also restores and builds the project, so you can use this single command to start the console app
5. To run tests:
   - Navigate to `PierresOrderApp.Solution/PierresOrderApp.Tests` in your command line.
   - Run the command `dotnet restore` to restore the dependencies that are listed in `PierresOrderApp.Tests.csproj`
   - Finally, run the command `dotnet test` to run the tests!

## Known Bugs

* _none. That I know of..._
---

## License [GPL] (https://choosealicense.com/licenses/gpl-3.0/)
_if you do run into any issues or have questions, ideas, or concerns; I would greatly encourage you to send feedback or make a contribution to the code_

---

## Contact Information
_Contact Giancarlo Vigneri at: bobloblaw.vigneri@gmail.com_ 

(What did one slice of bread say to another after a long day? Don't worry tomorrow will be butter.)