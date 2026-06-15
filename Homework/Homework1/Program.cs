// Task 1

Console.WriteLine("Write your Name");
var Name = Console.ReadLine();

Console.WriteLine();

Console.WriteLine("Write your first exam score");
var firstExamScore = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Write your second exam score");
var secondExamScore = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Write your homework score");
var homeworkScore = int.Parse(Console.ReadLine());

var averageScore = (firstExamScore + secondExamScore + homeworkScore) / 3;

if (averageScore > 100 || averageScore < 0)
{
    Console.WriteLine("არასწორი ქულა");
}
else if (averageScore >= 90)
{
    Console.WriteLine("თქვენი შეფასებაა - A");
    Console.WriteLine("ჩააბარა");
}
else if (averageScore >= 80)
{
    Console.WriteLine("თქვენი შეფასებაა - B");
    Console.WriteLine("ჩააბარა");
}
else if (averageScore >= 70)
{
    Console.WriteLine("თქვენი შეფასებაა - C");
    Console.WriteLine("ჩააბარა");
}
else if (averageScore >= 60)
{
    Console.WriteLine("თქვენი შეფასებაა - D");
    Console.WriteLine("ჩააბარა");
}
else
{
    Console.WriteLine("თქვენი შეფასებაა - F");
    Console.WriteLine("ვერ ჩააბარა");
}

Console.WriteLine();

// Task 2

int Balance = 1000;
int amount;
int input;

do
{
    Console.WriteLine("მენიუ:");
    Console.WriteLine("1 - ბალანსი");
    Console.WriteLine("2 - თანხის შეტანა");
    Console.WriteLine("3 - თანხის გამოტანა");
    Console.WriteLine("4 - გამოსვლა");
    Console.WriteLine();

    input = int.Parse(Console.ReadLine());

    switch (input)
    {
        case 1:
            Console.WriteLine($"თქვენი ბალანსია: {Balance} ლარი");
            break;

        case 2:
            Console.WriteLine("დაწერეთ შესატანი თანხის რაოდენობა:");
            amount = int.Parse(Console.ReadLine());
            Balance = Balance + amount;
            break;
        case 3:
            Console.WriteLine("დაწერეთ გამოსატანი თანხის რაოდენობა:");
            amount = int.Parse(Console.ReadLine());
            if (Balance > amount)
            {
                Balance = Balance - amount;
            }
            else
            {
                Console.WriteLine("ანგარიშზე არ არის საკმარისი თანხა:");
            }
            break;
    }
}
while (input != 4);

Console.WriteLine();

// Task 3


Console.WriteLine("შეიყვანეთ რიცხვი:");
var secondInput = int.Parse(Console.ReadLine());

if (secondInput > 0)
{
    Console.WriteLine("რიცხვი დადებითია");
}
else if (secondInput == 0)
{
    Console.WriteLine("რიცხვი ნულია");
}
else
{
    Console.WriteLine("რიცხვი უარყოფითია");
}

if (secondInput % 2  == 0)
{
    Console.WriteLine("რიცხვი ლუწია");
}
else
{
    Console.WriteLine("რიცხვი კენტია");
}

for (int i = 1; i < 11; i++)
{
    Console.WriteLine(secondInput * i);
}

// Task 4

string Username = "admin";
string Password = "12345";
string inputUsername;
string inputPassword;

var loopNumber = 0;

while (loopNumber < 3)
{
    Console.WriteLine("შეიყვანეთ Username");
    inputUsername = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine("შეიყვანეთ Password");
    inputPassword = Console.ReadLine();

    Console.WriteLine();
    
    if (inputUsername == Username && inputPassword == Password)
    {
        Console.WriteLine("კეთილი იყოს თქვენი მობრძანება");
        loopNumber += 4;
    }
    else
    {
        Console.WriteLine("არასწორი მონაცემები");
        loopNumber++;
    }

    if (loopNumber == 3) 
    {
        Console.WriteLine("ანგარიში დაიბლოკა");
    }
}

// Task 5

int menuChoice;

Console.WriteLine("შეიყვანეთ პირველი რიცხვი");
int thirdNumber = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("შეიყვანეთ მეორე რიცხვი");
int fourthNumber = int.Parse(Console.ReadLine());

Console.WriteLine("მენიუ:");
Console.WriteLine("1 - მიმატება");
Console.WriteLine("2 - გამოკლება");
Console.WriteLine("3 - გამრავლება");
Console.WriteLine("4 - გაყოფა");
Console.WriteLine();
menuChoice = int.Parse(Console.ReadLine());
switch (menuChoice)
{
    case 1:
        Console.WriteLine(thirdNumber + fourthNumber);
        Console.WriteLine();
        break;
    case 2:
        Console.WriteLine(thirdNumber - fourthNumber);
        Console.WriteLine();
        break;
    case 3:
        Console.WriteLine(thirdNumber * fourthNumber);
        Console.WriteLine();
        break;
    case 4:
        if (fourthNumber == 0)
        {
            Console.WriteLine("შეცდომა");
        }
        else
        {
            Console.WriteLine(thirdNumber / fourthNumber);
        }
        break;
    default:
        Console.WriteLine("არასწორი ოპერაცია");
        Console.WriteLine();
        break;
}