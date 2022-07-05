# AditumChalleng
Web API C# - .NET CORE 3.1

#DOCKER REPOSITORY: https://hub.docker.com/r/franciscojesousa/aditumchallenge

This project was created to implement a simple C# WEB API based on partial CRUD operations, the main focus was set to response JSON file related to user request about 
local restaurants openning hours.

I have just implemented the GET method, based on the priori and primer user necessity, get data from CSV file, and considering that other CRUD methods are denied for 
while.

I have implemented the "Restaurante" class to represent the restaurants attributes (name and openning hour interval), and the "RestauranteMap" class to map csv file 
columns

Using CsvHelper to read data from base and map the entity class "Restaurante" with csv columns names, cause them could be in a different way.

Using Swagger Open Api to provide a documentation of application and a frendly UI to use the GET method.

Using Docker to simulate different aplication enviroments.

In the module ADITUM.CHALLENGE.TESTE there are two class with test of main functios/methos related to applications functionality, I have chosen Xunit to developed 
those tests.







