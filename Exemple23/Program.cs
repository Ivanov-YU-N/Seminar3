/*Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N. */

int Number(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

void Result(int number)
{
    int i = 1;
    while(i < number + 1)
    {
        double result = Math.Pow(i, 3);
        Console.Write(result + " ");
        i++;
    }
}

int number = Number("Введите число ");
Result(number);
