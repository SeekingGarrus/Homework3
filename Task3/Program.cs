// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Первое решение
int N = new Random().Next(1, 101);
for (int i = 1; i <= N; i++) Console.WriteLine($"{i}x{i}x{i}={Math.Pow(i, 3)}");


// Второе решение.
// Подзадачи:
// 1. Создание массива
void AddText()
{
    Console.WriteLine("Введите число: ");
}

// 2. Ввод размера массива
int GetNumber()
{
    return Convert.ToInt32(Console.ReadLine());
}

// 3. Объявление массива
int[] CreateArray(int size) // функция создания массива
{
    return new int[size];
}

// 4. Формула куба и вывод результата
void Formula(int[] arr)
{
    for (int i = 1; i <= arr.Length; i++)
    {
        Console.WriteLine($"{i} ^ 3 = {Math.Pow(i, 3)}");
    }
}
Console.WriteLine();
AddText();
int size = GetNumber();
int[] array = CreateArray(size);

Formula(array);