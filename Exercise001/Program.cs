// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int ReadInt (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] InputArray (int length)
{
    int[] array = new int[length];
    for (int i=0; i<array.Length; i++)
    {
        array[i]= ReadInt($"Vvedite {i + 1}-oe chislo: ");
    }
    return array;
}

void PrintArray (int[] arrayForPrint)
{
    for (int i=0; i<arrayForPrint.Length; i++)
    {
        Console.WriteLine(arrayForPrint[i] + " ");
    }
}

int CountNumbers (int[] array)
{
    int count = 0;
    for (int i=0; i < array.Length; i++)
    {
        if (array [i] > 0)
        {
            count++;
        }
    }
    return count;
}

//-----------------
int numbers = ReadInt("Vvedite kolichestvo elementov: ");
int[] array;
array = InputArray(numbers);
PrintArray(array);
Console.WriteLine($"Kolichestvo chisel bolshe 0 = {CountNumbers(array)}");