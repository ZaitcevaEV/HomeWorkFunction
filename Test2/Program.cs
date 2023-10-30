// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SummOfDigits (string A)
{
    int len = A.Length;
    int result = 0;
    for(int i = 0; i < len; i++)
    {
        int digit = int.Parse(A[i].ToString());
        result = result + digit;
    }
    return result;
}

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int summOfDigits = SummOfDigits(number);
Console.WriteLine($"Сумма цифр числа '{number}' равна '{summOfDigits}'");