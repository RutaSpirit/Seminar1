// Напишите программу, кот. на вход принимает одно число(N), а на выходе показывает все целые числа в промежутке
// от -N до N
// task 5(решение с помощью цикла while)
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
int i = n * (-1);
while (i <= n)
{
    Console.Write($"{i} ");
    i = i + 1; // i++;
}

// task 5(решение с помощью цикла for)
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
for (int i = (-1) * n; i <= n; i++)
    Console.Write($"{i} ");


// task 5(решение с помощью цикла for без интерполяции строк)
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
for (int i = (-1) * n; i <= n; i++)
    Console.Write(i + "  ");

