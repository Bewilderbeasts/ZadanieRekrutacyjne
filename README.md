# ZadanieRekrutacyjne

## Table of contents
* [General info](#general-info)
* [Technologies](#technologies)


## General info
Simple console app, created for a recruitment at one of the companies. Given two dates, it returns range of those dates (earlier - later date). 
It takes OS local info to determine a DateTime format it will return, so to get back data formatted as this:

![Picutre showing on of the formats of returned dates](ZadanieRekrutacyjne/ZadanieRekrutacyjne/pics/ChnFormat.png?raw=true "Result")

We would need to change variable in Program.cs like this:

![Picture showing some Program.cs changes as an example](ZadanieRekrutacyjne/ZadanieRekrutacyjne/pics/chn2.png?raw=true "Code")

Otherwise it will return dated formatted in our OS's DateTime format.
	
## Technologies
Project is created with:
* C# version: 8.0
* .NET Core version: 5.0
