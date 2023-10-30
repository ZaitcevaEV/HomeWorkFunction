// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

string[] NewMassiv ()
{
    string[] newMassiv = new string[8];
    int len = newMassiv.Length;
    Console.WriteLine("Введите элементы массива:");
    for(int i = 0; i < len; i++)
    {
        Console.Write($"{i}: ");
        string A = Console.ReadLine();
        newMassiv[i] = A;
    }
    return newMassiv;
} 

string PrintMassiv (string[] M)
{
    string result = "[";
    int len = M.Length;
    for(int i = 0; i < len; i++)
    {
        if(i == len - 1)
        {
            result = result + $"{M[i]}]";
        }
        else
        {
            result = result + $"{M[i]}, ";
        }
    }
    
    return result;
}

string[] massiv = NewMassiv();
string printMassiv = PrintMassiv(massiv);
Console.WriteLine(printMassiv);