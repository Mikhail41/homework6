//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.Clear();
Console.WriteLine($"Эта программа находит точку пересечения двух прямых,заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.");
Console.WriteLine($"Значения b1, k1, b2 и k2 задаются пользователем.");
Console.WriteLine();
Console.Write($"Введи значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введи значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write($"Введи значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введи значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Данные введенные пользователем : {b1}, {k1}, {b2}, {k2}");
Console.WriteLine();

void CrossPoint(double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1);
    if (b1 == b2 & k1 == k2) Console.WriteLine("Прямые совпадают");
    else if (k1 == k2) Console.WriteLine("Прямые параллельны друг другу");

    else

        Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
}
CrossPoint(k1, b1, k2, b2);
