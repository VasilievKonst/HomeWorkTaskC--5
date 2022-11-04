
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






/*
Int indexof(int[] collection, int find)
{
    Int count = collection.leght;
    Int index = 0;
    Int position = 0;

    While (index < count)
    {
         If (collection[index] == find)
         {
              Position = index;
          }    
         Index++
     }
 Return position;    
}
Fullarray(array); // Вызываем определенный нами метод для заполнения массива
Printarray(array); // Вызываем определенный нами метод для вывода массива на экран
Console.writeline();
Int pos = indexof(array, 4);
Console.writeline(pos);

*/
