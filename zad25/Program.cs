/*
Задача 25: Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.

3, 5 -> 243
2, 4 -> 16
*/

int diggit()
{
    Console.WriteLine("Writte first diggit");
    int dig = Convert.ToInt32(Console.ReadLine());
    return dig;
}

void result(int num1, int num2)
{
    int i = 1;
    int res = num1;
    while (i < num2)
    {
       
        res *=  num1 ;
        i++;
    }
    Console.WriteLine($"{num1}, {num2} -> {res}");
}

void Lutsenko()
{
    Console.WriteLine("The author of the work - Lutsenko A.S.");
}



int A = diggit();
int B = diggit();

result(A, B);
Lutsenko();
