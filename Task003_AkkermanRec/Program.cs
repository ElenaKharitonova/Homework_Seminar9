// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
// m = 2, n = 3 -> A(m,n) = 9

int PromptInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int AkkermanRecursion (int m, int n) //Функция Аккермана
{
    if (m == 0) 
        {
            return n + 1;
        }
    if (m > 0 && n == 0) 
    {
        return AkkermanRecursion(m - 1, 1);
    }
    if (m > 0 && n > 0) 
    {
        return AkkermanRecursion(m - 1, AkkermanRecursion(m, n - 1));
    }
    return AkkermanRecursion(m, n);
}

bool ValidateNumber(int n, int m) // проверка введенного числа на соответствие
{
     if (m < 0 || n < 0)
     {
          System.Console.WriteLine("Одно из введенных чисел отрицательное");
          System.Console.WriteLine("Введите неотрицательные числа");
          return false;
     }
     return true;
}

System.Console.WriteLine("Введите два неотрицательных числа");
int m = PromptInt("Введите первое число (m): ");
int n = PromptInt("Введите второе число (n): ");
if (ValidateNumber(n, m))
{
Console.WriteLine($"Функция Аккермана для {m} и {n} = {AkkermanRecursion(m, n)}");
}