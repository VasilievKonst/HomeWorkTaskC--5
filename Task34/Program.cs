
int[] array = new int[15];

void FullArray(int[] collect)
{
    int lenght = collect.Length;
    int index = 0;
    while(index < lenght)
    {
        collect[index] = new Random().Next(100,999);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int SearchEL(int[] ar)
{
    int countAR = ar.Length;
    int ind = 0;
    int countEL = 0;
    while(ind < countAR)
    {
        if(ar[ind] % 2 == 0)
        {
            countEL++;
        }
        ind++;
    }
    return countEL;
}

void PrintResault()
{
    int count2el = SearchEL(array);
    if(count2el == 0)
    {
    Console.WriteLine("Четные числа в массиве отсутствуют!");
    }
    else
    {
        Console.Write("Колличество четных эллементов массива составляет: ");
        Console.WriteLine(count2el);
    }
}

Console.WriteLine("Задан массив: ");

FullArray(array);
PrintArray(array);
PrintResault();

