
int date = 0;
int result = 0;
int GetNumber(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

int Palinom(int number)
{
    while(number > 0)
    {
        date = number % 10;
        result = result * 10 + date;
        number /= 10;
         
    }
    return result;
}

void Print( int number, int result)
{
    if(number == result)
    {
    Console.WriteLine("Число " + number + "  полиндром");
    }
    else
    {
        Console.WriteLine("Число не является полиндромом");
    }
}

int number = GetNumber("Введите число  ");
Palinom(number);
Print(number, result);

