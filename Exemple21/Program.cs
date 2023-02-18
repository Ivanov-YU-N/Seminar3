int GetNumber(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

double Result(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double result = Math.Sqrt(x1 * x2 + y1 * y2 + z1 * z2);
    return result; 
}

void Print(double result)
{
    Console.WriteLine(result);
} 

int x1 = GetNumber("Введите значение х1 = ");
int y1 = GetNumber("Введите значение y1 = ");
int z1 = GetNumber("Введите значение z1 = ");
int x2 = GetNumber("Введите значение х2 = ");
int y2 = GetNumber("Введите значение y2 = ");
int z2 = GetNumber("Введите значение z2 = ");
double result = Result(x1, x2, y1, y2, z1, z2);
Print(result);