// Task 1

Console.WriteLine("რამდენი ციფრის შეყვანა გსურთ?");

int amount = int.Parse(Console.ReadLine());

var numbers = new int[amount];

for (int i = 0; i < amount; i++)
{
    Console.WriteLine($"შეიყვანეთ რიცხვი ნომერი {i + 1}");
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine();


int sum = 0;
int average = 0;
int max = numbers[0];
int min = numbers[0];

Console.WriteLine("თქვენი შეყვანილი რიცხვებია: ");

for (int i = 0; i < amount; i++)
{
    Console.Write(numbers[i] + "; ");

    sum += numbers[i];

    average += sum / amount;

    if (numbers[i] > max)
    {
        max = numbers[i];
    }

    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

Console.WriteLine();

Console.WriteLine("თქვენი შეყვანილი რიცხვების ჯამია: " + sum);

Console.WriteLine();

Console.WriteLine("თქვენი შეყვანილი რიცხვების საშუალო მნიშვნელობაა: " + average);

Console.WriteLine();

Console.WriteLine("ყველაზე დიდი რიცხვი - " + max);

Console.WriteLine();

Console.WriteLine("ყველაზე პატარა რიცხვი - " + min);


// Task 2

Console.WriteLine("რამდენი სტუდენტის შეყვანა გსურთ?");

int amount2 = int.Parse(Console.ReadLine());

var students = new List<string>(amount2);

for (int i = 0; i < amount2; i++)
{
    Console.WriteLine($"შეიყვანეთ სტუდენტი N{i + 1}");
    students.Add(Console.ReadLine());
}

Console.WriteLine();

int index = 1;

foreach (string student in students)
{
    Console.WriteLine($"სტუდენტი {index}: {student}");
    index++;
}

Console.WriteLine($"ჯამში სტუდენტების რაოდენობა: {amount2}");


// Task 3

Console.Write("შეიყვანეთ სიტყვა ან წინადადება: ");
string userInput = Console.ReadLine();

AnalyzeText(userInput);

void AnalyzeText(string text)
{
    int length = text.Length;

    string upperText = text.ToUpper();

    string lowerText = text.ToLower();

    bool containsCSharp = text.Contains("CSharp");

    string contains;

    if (containsCSharp)
    {
        contains = "შეიცავს";
    }
    else { contains = "არ შეიცავს"; }

    Console.WriteLine($"სიმბოლოების რაოდენობა: {length}");
    Console.WriteLine($"დიდი ასოებით: {upperText}");
    Console.WriteLine($"პატარა ასოებით: {lowerText}");
    Console.WriteLine($"შეიცავს თუ არა სიტყვას 'CSharp': {contains}");
}


// Task 4


string ReverseText(string text)
{
    if (text.Length <= 1)
    {
        return text;
    }

    return text[text.Length - 1] + ReverseText(text.Substring(0, text.Length - 1));
}

Console.WriteLine();

Console.Write("შეიყვანეთ სიტყვა: ");
string input = Console.ReadLine();
string reversedResult = ReverseText(input);

Console.WriteLine("შებრუნებული ტექსტი: " + reversedResult);

