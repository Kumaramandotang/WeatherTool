#To explore the application visual studio 2022 is recommended.

# How to explore the codes?

1. Open the solution folder (WeatherTool).
2. Now open "WeatherTool.sln" file.

# How to build and install application as package and install it in CLI?

1. Open the project folder(WeatherTool) and run the command line for the same directory.
2. Now execute the command "dotnet pack".
3. A new package fill will be generated in "pkg" folder.
4. Now execute the command "dotnet tool install --global --add-source ./pkg weathertool".
4. After doing this our tool is ready to use in command line using "pwcweather" command name. 
5. This tool provide two types of overloads
	1. pwcweather
	2. pwcweather <city name> example:- pwcweather kolkata
	
# How to build and install application as dotnet core project using CLI?

1. Open the project folder(WeatherTool) and run the command line for the same directory.
2. Now execute the command "dotnet run". This command have two overloads 
	1. dotnet run
	2. dotnet run <city name> example:- pwcweather kolkata	
	
	
# How to build and install application as dotnet core project using "Visual Studio 2022"?

1. Explore and open solution file "WeatherTool.sln".
2. Select "Build" --> "Build Solution" or press "Ctrl + Shift + B".
3. Select "Debug" --> "Start Debugging" or press "F5".
