// Задайте значения M и N. Напишите программу, которая 
// выведет все чётные натуральные числа в промежутке от M до N 
// с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int PromptInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintNumbersMN(int m, int n) 
{     
    if (n < m)     
    {         
        return;     
    }     
    Console.WriteLine(m);     
    PrintNumbersMN(m + 1, n); 
}  

void Even (int m, int n)
{   
    if (n < m)
    {
        return;
    }
    if (m % 2 != 0) ++m;
    System.Console.Write($"{m} ");
    Even(m+2,n);
}
System.Console.WriteLine("Задайте интервал вывода чисел");
int m = PromptInt("Введите m (нижняя граница): ");
int n = PromptInt("Введите n (верхняя граница): ");
Even(m,n);