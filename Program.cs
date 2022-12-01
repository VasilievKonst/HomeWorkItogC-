Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];

void FullAr(string[] arr)
{
    int k=0;
    for(int i = 0; i < n; i++)
    {
        k++;
        Console.Write($"Введите {k} эллемент массива: ");
        Console.ReadLine();
    }
}

FullAr(array);