/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

//метод возвращает число из консоли
string GetNumber(string message);
{
    int result = 0;
    string number = string.Empty;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while(true)
    {
        Console.WriteLine(message);
        number = Console.ReadLine();

        if(int.TryParse(number, out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }
    return number;
}



string number = GetNumber("Введите число:");
Console.WriteLine($"Число {number} имеет {SumNumber.Length} знаков");

