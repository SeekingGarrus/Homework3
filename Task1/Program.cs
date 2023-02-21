// Программа проверяет пятизначное число на палиндром. Рандомное заполнение массива.

// Решение без методов
int[] array = new int[5];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(10);
    Console.Write(array[i]);
}
if (array[0] == array[4] && array[1] == array[3]) Console.WriteLine(array + "- палиндром");
else Console.WriteLine(array + "- не палиндром");


// Другое решение с функцией и методами
// подзадачи:

// 1. Создание массива
int[] CreateArray(int size) // функция создания массива
{
    return new int[size];
}

// 2.Заполнение массива
void FillArray(int[] collection)// метод, который заполнит рандомный массив
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 6);
        index++;
    }
}

// 3. Вывод на печать созданного массива
void printArray(int[] array) // метод по выводу массива c for
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// 4. Проверка на палиндром
void palindrom(int[] arr)// метод проверки на палиндром
{
    if (arr[0] == arr[4] && arr[1] == arr[3]) Console.WriteLine("Палиндром");
    else Console.WriteLine("Не палиндром");
}


int[] array1 = CreateArray(5);
FillArray(array1);
printArray(array1);
palindrom(array1);