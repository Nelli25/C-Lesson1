// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
string first = Console.ReadLine();
int a = Convert.ToInt32(first);
Console.WriteLine("Введите второе число: ");
string second = Console.ReadLine();
int b = Convert.ToInt32(second);
if (a > b)
    {
        Console.WriteLine("Большее число: ");
        Console.WriteLine(a);
        Console.WriteLine("Меньшее число: ");
        Console.WriteLine(b);
    }
else
    {
        Console.WriteLine("Большее число в задаче № 2: ");
        Console.WriteLine(b);
        Console.WriteLine("Меньшее число в задаче № 2: ");
        Console.WriteLine(a);
    }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
string frst = Console.ReadLine();
int c = Convert.ToInt32(frst);
Console.WriteLine("Введите второе число: ");
string scnd = Console.ReadLine();
int d = Convert.ToInt32(scnd);
Console.WriteLine("Введите третье число: ");
string thrd = Console.ReadLine();
int e = Convert.ToInt32(thrd);
int result = c;
{
    if (d > result) result = d;
    if (e > result) result = e;
    Console.WriteLine("Максимальное число в задаче № 4: ");
    Console.WriteLine(result);
}

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число для задачи №6: ");
string number = Console.ReadLine();
int f = Convert.ToInt32(number);
if (f % 2 == 0)
{
    Console.WriteLine("Число четное!");
}
else Console.WriteLine("Число нечетное!");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает 
// все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число для задачи №8: ");
string nmber = Console.ReadLine();
int N = Convert.ToInt32(nmber);
int i = 1, k = 1;            
for (i = 1; k < N; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i + " ");
        k++;
    }
       
}

