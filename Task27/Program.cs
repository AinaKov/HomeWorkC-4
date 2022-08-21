/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int N = number.Length;
int number1 = Convert.ToInt32(number);
int sum = 0;
if (number1 < 0)
{
    number1 = -1 * number1;
    N = N - 1;
}
for (int i = 0; i < N; i++)
{
    sum = sum + number1.ToString()[i] - 48; //не могу понять, почему программа увеличивает каждое число на 48. Поэтому теперь я его вычитаю и работает правильно. Но откуда оно взялось - не  знаю, всяко пробовала и проверяла.
}
Console.WriteLine(sum);