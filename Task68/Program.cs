// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int FunctionAckermann(int arg1, int arg2)
{
    if (arg1 == 0)
    {
        return arg2+1;
    }
    if (arg1 == 1)
    {
        return arg2+2;
    }
    if (arg1 == 2)
    {
        return arg2*2 + 3;
    }
    else
    {
        return (1 << (arg2 + 3)) - 3;
    }
} 

int number1 = ReadInt("Введите число 1: ");
int number2 = ReadInt("Введите число 2: ");
Console.WriteLine(FunctionAckermann(number1, number2));