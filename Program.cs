/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    3, 5 -> 243 (3⁵)
    2, 4 -> 16
*/

/*
Console.Write("Введите основание степени ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите показатель степени ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine($"{x} в степени {y} = {F(x,y)}");

int F(int A, int B)
{
    int s = 1;
    for(int i=1; i<=B; i++)
        s*=A;
    return s;     
}
*/


/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    452 -> 11
    82 -> 10
    9012 -> 12
*/

/*
Console.Write("Введите число ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine($"сумма цифр числа {x} = {Sum(x)}");

int Sum(int n)
{
    int s = 0;
    while(n > 0)
    {
        s += n % 10;
        n /= 10;
    }
    return s;     
}
*/


/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
    6, 1, 33 -> [6, 1, 33]
*/

// я тут не очень поняла условие в соответствии с примерами: массив любой длины или из 8 элементов? 
// делаю произвольной длины для универсального случая

int d = new Random().Next(5,20);
int[] m = new int[d]; 
Console.WriteLine($"Массив из {d} элементов:");
input_mas(m);
print_mas(m);

void input_mas(int[] mas)
{
    int n = mas.Length;
    Random rnd = new Random();
    for(int i=0; i<n; i++)
        mas[i] = rnd.Next(1,100);
}

void print_mas(int[] mas)
{
    int n = mas.Length;
    for (int i=0; i<n; i++)
        Console.Write(mas[i] + " ");
     Console.WriteLine();   
}