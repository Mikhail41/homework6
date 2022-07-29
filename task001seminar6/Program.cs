//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

Console.WriteLine($"Пользователь вводит с клавиатуры M чисел, Программа подсчитывает сколько чисел больше 0 ввёл пользователь.");
Console.WriteLine();
Console.Write($"Введи количество чисел: ");

int m = Convert.ToInt32(Console.ReadLine());
int[] Massive = new int[m];

void InputNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        Massive[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    Console.WriteLine("Получившийся массив :");
    Console.WriteLine(String.Join(" ", Massive));
}

int Calculation(int[] Massive)
{
    int count = 0;
    for (int i = 0; i < Massive.Length; i++)
    {
        if (Massive[i] > 0) count += 1;
    }
    return count;
}

InputNumbers(m);
Console.WriteLine();
Console.WriteLine($"Введено чисел больше 0 : {Calculation(Massive)} ");
Console.WriteLine();