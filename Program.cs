


void ArrayShow(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void ArrayShowDouble(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double[] point(double k1, double b1, double k2, double b2)
{
    double[] point2 = new double [2];
    double x = ((b2-b1)/(k1-k2));
    double y = (k1*x+b1);

    point2[0]=x;
    point2[1]=y;
    return point2;
} 



// test 41 sem#6 c# Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
Console.Write("Введите количество чисел для ввода (от 0 до 10 ): ");

int a1 = Convert.ToInt32(Console.ReadLine());

int[] array = new int [a1];
int sum = 0;
int n;

for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите число: ");
    n = Convert.ToInt32(Console.ReadLine()); 
    array[i] = n;
    
    if (array[i] > 0) sum++;
}

ArrayShow(array);

Console.Write("В сформированном числовом ряду положительных чисел:  " + sum);
*/


// test 43 sem#6 c# Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите коэффициент k1 ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите коэффициент b1 ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите коэффициент k2 ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите коэффициент b2 ");
int b2 = Convert.ToInt32(Console.ReadLine());

ArrayShowDouble(point(k1, b1, k2, b2));
