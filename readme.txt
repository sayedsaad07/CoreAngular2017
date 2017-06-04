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

publish and release
 	dotnet public -c release
