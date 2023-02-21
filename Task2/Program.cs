// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.(например A (3,6,8); B (2,1,-7), -> 15.84)

//Первое решение. Рандомное введение координат.
int x1 = new Random().Next(-100, 101); // декартова система координат, ось x
int y1 = new Random().Next(-100, 101); // ось y,
int z1 = new Random().Next(-100, 101); // высота z
int x2 = new Random().Next(-100, 101);
int y2 = new Random().Next(-100, 101);
int z2 = new Random().Next(-100, 101);
//  Формула для расстояния между двумя точками в 3-х измерениях: sqrt {(x2-x1) ^{2} + (y2-y1) ^{2} + (z2-z1) ^{2}}
double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)); // Math.Sqrt - корень, Math.Pow - возведение в степень
Console.WriteLine($"При координатах точек ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) расстояние между ними +{Math.Round(result, 2)}");


// Второе решение. Ручное введение координат
// Подзадачи:
// 1. Введение текста
void AddText(string message)
{
    Console.WriteLine(message);
}

// 2. Заполнение координат руками пользователя
int GetNumber() 
{
    return Convert.ToInt32(Console.ReadLine());
}

// 3. Вычисление формулы
double distans3D(int a1, int b1, int c1, int a2, int b2, int c2) 
{ 
    return Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2) + Math.Pow((c2 - c1), 2)); 
}

// 4. Отсекание лишних цифр после запятой 
double roundNumber(double num)
{
    return Math.Round(num, 2);
}


AddText("Введите первые координаты");
int a1 = GetNumber();
int b1 = GetNumber();
int c1 = GetNumber();
AddText("Введите вторые координаты");
int a2 = GetNumber();
int b2 = GetNumber();
int c2 = GetNumber();

double result1 = distans3D(a1, b1, c1, a2, b2, c2);
double endresult = roundNumber(result);
Console.WriteLine($"Расстояние между координатами двух точек: {endresult}");