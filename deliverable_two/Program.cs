// See https://aka.ms/new-console-template for more information


int maxpeople = 6;
string choice1 = "water";
string choice2 = "coffee";
double choice1_price = 0;
double choice2_price = 2;
double buffet_price = 9.99;
double total_bill;
int choice1_total = 0;
int choice2_total = 0;
string answer;


Console.Write("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, parties of " + maxpeople + " or lower. ");
int people = int.Parse(Console.ReadLine());
Console.WriteLine();

if (people <= maxpeople) { 

    Console.WriteLine("A table for "+ people +"! Please follow me and take a seat.");
    Console.WriteLine("Let's get everyone started with some drinks. We've got " + choice1 + " or " + choice2 + ".");
    Console.WriteLine();

    for (int i = 1; i <= people; i++)
    {
        Console.Write("Alright, person number " + i + ", " + choice1 + " or " + choice2 + "?");
        answer = Console.ReadLine();
        if (answer == choice1) { choice1_total++; Console.WriteLine(answer + " , good choice!"); }
            else if (answer == choice2) { choice2_total++; Console.WriteLine(answer + " , okay!"); }
            else Console.WriteLine("We don't have that. No drink for you!");
        Console.WriteLine();
    }

    Console.WriteLine("Okay, so that's " + choice1_total + " " + choice1 + "(s) and " + choice2_total + " " + choice2 + "(s). I'll be right back. Feel free to grab your food!");
    Console.WriteLine();
    Console.WriteLine("...");
    Console.WriteLine();
    total_bill = (people * buffet_price) + (choice1_total * choice1_price) + (choice2_total * choice2_price);
    Console.WriteLine("Here's your bill! Total price: $" + total_bill + ".");
}

else

    Console.WriteLine("Oh sorry, can only seat parties up to " + maxpeople + ". Have a nice day.");