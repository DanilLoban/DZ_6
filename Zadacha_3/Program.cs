// See https://aka.ms/new-console-template for more information
Console.Write("Введите число, ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [size];
int sum = 0;
for(int i = 0; i < size; i++)
{
    arr[i] = new Random().Next(0, 100);
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < size; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}
for(int i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--)
{
    int a = arr[i] * (arr[j]);
    sum = sum + a;
}
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Итоговая сумма sum: {sum}");