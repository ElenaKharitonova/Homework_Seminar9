// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N 
// с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int PromptInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int SumRecursion (int m, int n)
{   
    if (n < m)
    {
        return 0;
    }
    int sum = m + SumRecursion(m+1,n);
    return sum;
}

System.Console.WriteLine("Задайте итервал поиска суммы чисел");
int m = PromptInt("Введите натуральное число m (нижняя граница): ");
int n = PromptInt("Введите натуральное число n (верхняя граница): ");
System.Console.Write($"Сумма чисел равна:{SumRecursion(m,n)}");
