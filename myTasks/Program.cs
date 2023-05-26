// ЗАДАЧА 1 (41). Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("ЗАДАЧА 1.");
int countNumbers = 0;
int countEvenNumbers = 0;
string quit = "processing";
while (quit.Equals("processing"))
{
    int userNumber = GetUserInput1("число");
    countNumbers++;
    if (userNumber > 0 ) countEvenNumbers++;
    Console.WriteLine($"Введённых чисел: {countNumbers}; положительных: {countEvenNumbers}.");
    int exit = GetUserInput1("0 для завершения, либо любое другое число для продолжения");
    if (exit == 0) quit = "stop!";
}
Console.WriteLine();
Console.WriteLine($"РЕЗУЛЬТАТ: Введённых чисел: {countNumbers}; положительных: {countEvenNumbers}.");

int GetUserInput1(string name)
{
    Console.WriteLine();
    Console.Write($"Введите {name} : ");
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}
// ***************************************************************************************************************************************
// ЗАДАЧА 2 (43). Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("ЗАДАЧА 2.");
int k1 = GetUserInput2("k1");
int b1 = GetUserInput2("b1");
int k2 = GetUserInput2("k2");
int b2 = GetUserInput2("b2");
double[] crossLinesCoord = GetCrossLinesCoord(k1, b1, k2, b2);
PrintArray(crossLinesCoord);

int GetUserInput2(string name)
{
    Console.WriteLine();
    Console.Write($"Введите параметр {name} : ");
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

double[] GetCrossLinesCoord(int k1, int b1, int k2, int b2)
{
    int xCross = (b2 - b1)/(k1 - k2);
    int yCross = k1*(b2 - b1)/(k1 - k2) + b1;
    double[] crossLinesCoord = {xCross, yCross};
    return crossLinesCoord;
}

void PrintArray(double[] arrayExample)
{
    Console.WriteLine($"Координаты точки пересечния:  x = {arrayExample[0]},  y = {arrayExample[1]}");
    Console.WriteLine();
}