// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, Egert!");


//mis sugu?? (m/f)
//perekonnanimi? 
//Tere..

Console.WriteLine("Please select your gender(m/f):");

char userGender = char.Parse(Console.ReadLine());
Console.WriteLine("Please enter your name:");
string userLastName = Console.ReadLine();
//Console.WriteLine("Welcome "+ (userGender)+ "!");

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName} !");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}


else
{
    Console.WriteLine("Welcome, " + (userLastName)+ "!");
}

