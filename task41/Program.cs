Console.WriteLine("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("[" + string.Join(", ", array) + "]");

int count = 0;
for (int i = 0; i < n; i++)
{
    if ( array[i] > 0)
    count++;
}
Console.WriteLine("Количество чисел больше нуля: " + count);