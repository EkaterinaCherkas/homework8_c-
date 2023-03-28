//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге
//получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] Array = Random(rows,columns);

int[,] Random(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(1,9);
        }

    }
    return result;
}
void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
}
Console.WriteLine();
}
Random(rows,columns);
Console.WriteLine("Исходный массив: ");
PrintArray(Array);

void sortirovka(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1) - 1; j++)
{
for (int k = 0; k < array.GetLength(1) - 1 ; k++)
{
if (array[i, k] < array[i, k + 1])
{
int temp = 0;
temp = array[i, k + 1];
array[i, k + 1] = array[i, k];
array[i, k] = temp;
}
}
}
}
}
sortirovka(Array);
Console.WriteLine("Отсортированный массив: ");
PrintArray(Array);
