/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void SumDigit(int num)
{
int num2 = num;
int result = 0;
if (num > 0)
{
while (num2 > 1)
{
    
    result += num % 10;
    num2 /= 10; 
}
result += num2;
Console.WriteLine($"{num} -> {result}");
}
else 
{
num = num * -1;
num2 = num;
while (num2 > 1)
{
    
    result += num % 10;
    num2 /= 10; 
}
result += num2 ;
Console.WriteLine($"{-num} -> {-result}");
}
}
void Lutsenko()
{
    Console.WriteLine("The author of the work - Lutsenko A.S.");
}



int digit = ReadInt("Write you digit ");

SumDigit(digit);

Lutsenko();

