//Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
//
//(*) В 3-й задаче Доп сложность. Ввод с консоли “введите количество элементов массива”, 
//“Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”

int Prompt(string massage)
{
    Console.Write(massage);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

int[] GenerateArray(int len, int min, int max)
{
    int[] list1 = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < list1.Length; i++)
    {
        list1[i] = rnd.Next(min, max + 1);
    }
    return list1;
}

void PrintArrey(int[] Arrey)
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + " ");
    }
}

int len = Prompt("Введите массив = ");
int min = Prompt("Введите минимальное значение = ");
int max = Prompt("Введите максимальное значение = ");
int[] Arrey = GenerateArray(len,min,max);

PrintArrey(Arrey);