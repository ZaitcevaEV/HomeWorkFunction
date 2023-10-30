// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int NaturalDegree (int A, int B)
{
    int result = A;
    for(int i = 1; i < B; i++)
    {
       result *= A;
    }
    return result;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели: {number}. Введите степень для возведения");
int natural = Convert.ToInt32(Console.ReadLine());
int naturalDegree = NaturalDegree(number, natural);
Console.WriteLine($"Число {number} в степени {natural} равно {naturalDegree}");