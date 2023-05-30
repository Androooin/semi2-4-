/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int [] CreateNewArray(int size)
{
int [] newArray = new int [size];
for (int i = 0; i < size; i++)
{
    newArray[i] = new Random().Next(1,100);
}
  return newArray;
} 

void PrintNewArray(int [] array)
{
    int index = array.Length -1;
    Console.Write("[");
    for(int i = 0; i < array.Length -1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[index]}]");
}

void Lutsenko()
{
    Console.WriteLine("The author of the work - Lutsenko A.S.");
}
 



int number = 8;
int [] arraystart = CreateNewArray(number);

PrintNewArray (arraystart);

Lutsenko();
