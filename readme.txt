Angular/CLI helper
	"npm install --save-dev @angular/cli@latest"
	ng generate service MyService

install aspnet core templates
C:\ESAAD\_Trainings\ASPCoreAngular>
dotnet new --install Microsoft.AspNetCore.SpaTemplates::*

create angular
	dotnet new angular

restore dotnet dependencies
	dotnet restore
restore node depenencies
	npm install
run app
	dotnet run

U can use VS 2017 to run the app

WebPack: enables ontime compile and update page by replacing code 
	enables webpack
	powershell: $Env:ASPNETCORE_ENVIRONMENT = "Development"
	Or CMD: setx ASPNETCORE_ENVIRONMENT "Development"
	show settings: echo ASPNETCORE_ENVIRONMENT
	command: webpack --config webpack.config.vendor.js

publish and release production version
 	dotnet publish -c release

Create Azure Web App
Create GITHUB Repo

	git init
	git add README.md
	git commit -m "first commit"
	git remote add origin https://github.com/sayedsaad07/CoreAngular2017.git
	git push -u origin master



Entity Core
	Open the Package Manager Console (PMC): Tools > NuGet Package Manager > Package Manager Console
		Install-Package Microsoft.EntityFrameworkCore.SqlServer
		Install-Package Microsoft.EntityFrameworkCore.Tools in the PMC
	Database Migration
		Add-Migration firstMigration
Create your database
		Once you have a model, you can use migrations to create a database.
		Open the PMC:
		Tools –> NuGet Package Manager –> Package Manager Console
			Add-Migration InitialCreate 
			Remove-Migration
			Update-Database 
				to apply the new migration to the database. This command creates the database before applying migrations.
Once migration tools only 2 commands add migration and update database 
			Add-Migration My_migration_version_name 
			Update-Database 