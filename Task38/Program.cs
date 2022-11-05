double[] array = new double[6];

void FullArray(double[] collect)
{
    int lenght = collect.Length;
    int index = 0;
    while(index < lenght)
    {
        collect[index] = new Random().Next(-100,100);
        index++;
    }
}

void PrintArray(double[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

double SearchMAX(double[] ar)
{
    int countAR = ar.Length;
    int ind = 0;
    double  max = ar[ind];
    while(ind < countAR)
    {
        if(ar[ind] > max)
        {
            max = ar[ind];
        }
        ind++;
    }
    return max;
}

double SearchMIN(double[] arm)
{
    int countARR = arm.Length;
    int inde = 0;
    double min = arm[inde];
    while(inde < countARR)
    {
        if(arm[inde] < min)
        {
            min = arm[inde];
        }
        inde++;
    }
    return min;
}
void PrintResault()
{
    double resaultsum = Math.Abs(SearchMAX(array)) - Math.Abs(SearchMIN(array));
   
    Console.Write("Разность между максимальным и минимальным элементом массива составляет: ");
    Console.WriteLine(resaultsum);
}

Console.WriteLine("Задан массив: ");

FullArray(array);
PrintArray(array);
PrintResault();
