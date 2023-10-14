//vanus??

//Console.WriteLine("Enter your age:");
//int userAge = Int32.Parse(Console.ReadLine());


//if (userAge > 12)
//if (userAge>= 13)
//{
 //   Console.WriteLine("Welcome to Instagram!");
//}
//else
//{
//    Console.WriteLine("LIIGA noor!!");
//}





Console.WriteLine("Enter your age:");

string userAge2 = Console.ReadLine();

Int32 userAgeNumber = 0;

bool userAgeNum = Int32.TryParse(userAge2, out userAgeNumber);

if (userAgeNum == true)
    if (userAgeNumber >= 13)
    {
        Console.WriteLine("Welcome to Instagram!");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram!");
    }
else
{
    Console.WriteLine("Could not read your entered age!");
}


