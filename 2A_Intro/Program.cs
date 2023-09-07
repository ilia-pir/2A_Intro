
#region Variables

int age = 21;
string name = "Ilia";
bool tired = true;
float grade = 2.3f;

#endregion



#region Function Calls

Say();
Say(name);
Say("neu");

AddInts(a: age,b: 7);
MinusInts(a: age,b: 5);
MalInts(a: age,b: 5);
GeteiltInts(a: age,b: 5);


IsRich(22); // Your financial status
HighestNumOfTwo(a: 22, b: 212); // What number is higher?
HighestNumOfThree(a: 222, b: 233, c: 434); // Highest Number of the three

HalfOfNum(number: 120); // Whats the half of this number?
PercentOfNum(percent: 14, number: 1302); // How much is x percent of x?
Score(74, 74); // Which Score is higher and who wins?
Age(2002,2023); // How old are you?
#endregion



#region Functions

void Say(string textToSay = "Text")
{
    Console.WriteLine(textToSay);
}

void AddInts(int a, int b)
{
    int solution = a + b;
    
    Console.WriteLine(solution);
}

void MinusInts(int a, int b)
{
    int solution = a - b;
    
    Console.WriteLine(solution);
}

void MalInts(int a, int b)
{
    int solution = a * b;
    
    Console.WriteLine(solution);
}

void GeteiltInts(int a, int b)
{
    int solution = a / b;
    
    Console.WriteLine(solution);
}

void IsRich(int money)
{
    Console.WriteLine("You have " + money + " money!");
    
    if (money > 150)
    {
        Console.WriteLine("You are rich!");
    }
    else if (money < 0)
    {
        Console.WriteLine("You are going to die!");
    }
    else
    {
        Console.WriteLine("You are a loser!");
    }
}

void HighestNumOfTwo(int a, int b)
{
    if (a == b)
    {
        Console.WriteLine("They are equal");
    }
    else if (a > b)
    {
        Console.WriteLine(a + " is the higher number!");
    }
    else
    {
        Console.WriteLine(b + " is the higher number!");
    }
}

void HighestNumOfThree(int a, int b, int c)
{
    if (a > b && a > c)
    {
        Console.WriteLine(a);
    }
    else if (b > c && b > a)
    {
        Console.WriteLine(b);
    }
    else
    {
        Console.WriteLine(c);
    }
    
}

void HalfOfNum(float number)
{
    float solution = number / 2;
    
    Console.WriteLine(solution);
}

void PercentOfNum(float percent, float number)
{
    float solution = number * percent / 100;
    
    Console.WriteLine(solution);
}

void Score(int score1, int score2)
{
    if (score1 == score2)
    {
        Console.WriteLine("Score1: " + score1);
        Console.WriteLine("Score2: " + score2);
        Console.WriteLine("Draw!");
    }
    else if (score1 > score2)
    {
        Console.WriteLine("Score1: " + score1);
        Console.WriteLine("Score2: " + score2);
        Console.WriteLine("Player 1 wins!");
    }
    else
    {
        Console.WriteLine("Score1: " + score1);
        Console.WriteLine("Score2: " + score2);
        Console.WriteLine("Player 2 wins!");
    }
}

void Age(int born, int now)
{
    int solution = now - born;
    
    Console.WriteLine("You are " + solution + " years old.");
}

#endregion
 