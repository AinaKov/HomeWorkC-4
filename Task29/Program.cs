/* Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

//своими силами смогла сделать только такую формулу
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество чисел: ");
        int elementsCount = int.Parse(Console.ReadLine());
        int[] array = new int[elementsCount];
        Console.Write("Вводите числа: ");
        for (int i = 0; i < elementsCount; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Массив:  ");
        for (int i = 0; i < array.Length-1; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.WriteLine(array[array.Length - 1] + ".");
    }
}
