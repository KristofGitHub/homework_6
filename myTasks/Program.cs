// ЗАДАЧА 1 (41). Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int countNumbers = 0;
int countEvenNumbers = 0;
string quit = "processing";
while (quit.Equals("processing"))
{
    int userNumber = GetUserInput("число");
    countNumbers++;
    if (userNumber > 0 ) countEvenNumbers++;
    Console.WriteLine($"Введённых чисел: {countNumbers}; положительных: {countEvenNumbers}.");
    int exit = GetUserInput("0 для завершения");
    if (exit == 0) quit = "stop!";
}
Console.WriteLine($"Введённых чисел: {countNumbers}; положительных: {countEvenNumbers}.");

int GetUserInput(string name)
{
    Console.WriteLine();
    Console.Write($"Введите {name} : ");
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}
// ***************************************************************************************************************************************
