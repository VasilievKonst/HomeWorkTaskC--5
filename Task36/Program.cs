
int[] array = new int[6];

void FullArray(int[] collect)
{
    int lenght = collect.Length;
    int index = 0;
    while(index < lenght)
    {
        collect[index] = new Random().Next(-100,100);
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

int SearchSUM(int[] ar)
{
    int countAR = ar.Length;
    int ind = 0;
    int sum = 0;
    while(ind < countAR)
    {
        if(ind % 2 != 0)
        {
            sum += ar[ind];
        }
        ind++;
    }
    return sum;
}

void PrintResault()
{
    int resaultsum = SearchSUM(array);
   
    Console.Write("Сумма чисел массива стоящих на нечетных позициях составляет: ");
    Console.WriteLine(resaultsum);
}

Console.WriteLine("Задан массив: ");

FullArray(array);
PrintArray(array);
PrintResault();
