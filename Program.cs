using System;

string? GetInput(string prompt) {
    Console.Write(prompt);
    string? b = Console.ReadLine();
    Console.WriteLine();

    return b;
}


var name = GetInput("What's your name? ");
var age = Int32.Parse(GetInput("What's your age? "));
var eyecolor = GetInput("What's your eye color? ");
var haircolor = GetInput("What's your hair color? ");
var shoesize = GetInput("What's your shoe size? ");
var favoritecolor = GetInput("What's your favorite color? ");
var favoritemedia = GetInput("What's your favorite TV show or Movie? ");
var favoriteteacher = GetInput("Who's your favorite teacher? ");
var favoriteclass = GetInput("What's your favorite class? ");
var favoriteholiday = GetInput("What's your favorite holiday? ");
var favoriteseason = GetInput("What's your favorite season? ");
var dreamjob = GetInput("What's your dream job? ");
var ageinfiveyears = age + 5;
var howmanysiblings = Int32.Parse(GetInput("How many siblings do you have? "));

Console.WriteLine($"My friend's name is {name}. {name} is {age} years old. {name}'s eye color is {eyecolor}, their haircolor is {haircolor} their shoesize is {shoesize} their favorite color is {favoritecolor} their favorite tv show/movie is {favoritemedia} their favorite teacher is {favoriteteacher} their favorite class is {favoriteclass} their favorite holiday is {favoriteholiday} their favorite season is {favoriteseason} their dream job is to be a {dreamjob} they will be {ageinfiveyears} in five years and they have {howmanysiblings} siblings");