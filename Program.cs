
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = new string[n];
string[] NewAr = new string[n];

// метод заполнения основного массива с клавиатуры

void FullAr(string[] arr)
{
    int k=0;
    for(int i = 0; i < n; i++)
    {
        k++;
        Console.Write($"Введите {k} эллемент массива: ");
        arr[i] = Console.ReadLine();
    }
}

// метод проверки основного массива и перенос элементов в новый массив

void createAR(string[] arr1, string[] arr2)
{
    int pos = 0;
    for(int l = 0; l < n; l++)
    {
        if(arr1[l].Length <= 3)
        {
            arr2[pos] = arr1[l];
            pos++;
        }
    }
}

// метод вывода на печать нового массива

void PrintAr(string[] NewAR, string text)
{
    Console.WriteLine(text+": ");
    for(int j = 0; j < n; j++)
    {
        Console.Write($"{NewAR[j]} ");
    }
    Console.WriteLine();
}

FullAr(array);
createAR(array, NewAr);
PrintAr(array, "Заданный вами основной массив выглядит так");
PrintAr(NewAr, "Исходя из условий поставленной задачи, получаем следующие данные");

