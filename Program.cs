using System;

public class Program {
    static string name, eyecolor, haircolor, favoritecolor, 
                  shoesize, favoritemedia, favoriteteacher, 
                  favoriteclass, favoriteseason, dreamjob, 
                  howmanysiblings, favoriteholiday;

    static int ageinfiveyears, age;

    static void Main(string[] args) {
        AskName();
        AskEyeColor();
        AskHairColor();
        AskFavoriteColor();
        AskShoeSize();
        AskFavoriteClass();
        AskFavoriteMedia();
        AskFavoriteTeacher();
        AskFavoriteSeason();
        AskDreamJob();
        AskHowManySiblings();
        AskFavoriteHoliday();
        CalculateAgeIn5Years(age+"");

        DisplaySummaryMessage();
    }


    static string? GetInput(string prompt) {
        Console.Write(prompt);
        string? b = Console.ReadLine();
        Console.WriteLine();

        return b;
    }

    static void AskName() {name = GetInput("What's your name? ");}


    static void AskAge (){age = Int32.Parse(GetInput("What's your age? "));}
    static void AskEyeColor(){eyecolor = GetInput("What's your eye color? ");}
    static void AskHairColor(){haircolor = GetInput("What's your hair color? ");}
    static void AskShoeSize(){shoesize = GetInput("What's your shoe size? ");}
    static void AskFavoriteColor(){favoritecolor = GetInput("What's your favorite color? ");}
    static void AskFavoriteMedia(){favoritemedia = GetInput("What's your favorite TV show or Movie? ");}
    static void AskFavoriteTeacher(){favoriteteacher = GetInput("Who's your favorite teacher? ");}
    static void AskFavoriteClass(){favoriteclass = GetInput("What's your favorite class? ");}
    static void AskFavoriteHoliday(){favoriteholiday = GetInput("What's your favorite holiday? ");}
    static void AskFavoriteSeason(){favoriteseason = GetInput("What's your favorite season? ");}
    static void AskDreamJob(){dreamjob = GetInput("What's your dream job? ");}
    static void CalculateAgeIn5Years(string age){ageinfiveyears = Int32.Parse(age) + 5;}
    static void AskHowManySiblings(){howmanysiblings = GetInput("How many siblings do you have? ");}

    static void DisplaySummaryMessage() {
        Console.WriteLine($"My friend's name is {name}. {name} is {age} years old. {name}'s eye color is {eyecolor}, their haircolor is {haircolor} their shoesize is {shoesize} their favorite color is {favoritecolor} their favorite tv show/movie is {favoritemedia} their favorite teacher is {favoriteteacher} their favorite class is {favoriteclass} their favorite holiday is {favoriteholiday} their favorite season is {favoriteseason} their dream job is to be a {dreamjob} they will be {ageinfiveyears} in five years and they have {howmanysiblings} siblings");
    }
}
