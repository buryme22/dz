Задание №1

Console.WriteLine("Введите первое число: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи второе число: ");

int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) 
{
    Console.WriteLine($"Число {num1} больше, чем {num2}");
}

else
{
    Console.WriteLine($"Число {num2} больше, чем {num1}");
}


Задание №2

Console.WriteLine("Введите первое число: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");

int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2>max)
    max = num2;

if (num3>max);
    max=num3;

Console.WriteLine($"Максимальное из введенных чисел = {max}");


Задание №3

int a;

Console.WriteLine("Введите число: ");

a = Convert.ToInt32(Console.ReadLine()); 

if (a % 2 == 0)

{

Console.WriteLine("Четное число");

}

else

{

Console.WriteLine("Нечетное");

}

Задание №4

Console.WriteLine("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());
        
int res = 1;
       
if (res == 1)

{
    res += 1;
}

while (res <= num)

{

Console.WriteLine(res);

res += 2;

}